using System;
using System.IO;
using Microsoft.ML.Runtime.Data;
using Microsoft.ML.Runtime.Learners;

namespace USTG_MG.AppWin32.ML
{
    public class ServicoPredicaoControl
    {
        public static float carregar(float Prioridade, float Punicao, float Dispensa, float UltimoDiaSemana, float DiaAtualSemanaServico)
        {       
            string pathModel = "model.pb";


            if (!File.Exists(pathModel))
            {
                WaitForm waitForm = new WaitForm("Modelo em treinamento...", ServicoPredicaoControl.criar_e_treinar);
                waitForm.ShowDialog();
            }

            FileStream fs = File.OpenRead(pathModel);
            var env = new LocalEnvironment();

            var model = TransformerChain.LoadFrom(env, fs);

            var prediction = model.MakePredictionFunction<ModeloPredicao, ServicoPredicao>(env).Predict(
                    new ModeloPredicao()
                    {
                        prioridade = Prioridade,
                        punicao = Punicao,
                        dispensa = Dispensa,
                        ultimoDiaSemana = UltimoDiaSemana,
                        diaAtualSemanaServico = DiaAtualSemanaServico
                    }
            );

            fs.Close();

            return prediction.PredictedLabels;
        }
        
        public static void criar_e_treinar()
        {        
            string dataPath = "data.csv";
            string outputModel = "model.pb";

            if (!File.Exists(dataPath))
                throw new Exception("Arquivo <data.csv> contendo dados para treinamento não existe");

            var env = new LocalEnvironment();
            var reader = new TextLoader(env, 
                new TextLoader.Arguments()
                {
                    Separator = ";",
                    HasHeader = false,
                    Column = new[]
                    {
                        new TextLoader.Column("prioridade", DataKind.R4, 0),
                        new TextLoader.Column("punicao", DataKind.R4, 1),
                        new TextLoader.Column("dispensa", DataKind.R4, 2),
                        new TextLoader.Column("ultimoDiaSemana", DataKind.R4, 3),
                        new TextLoader.Column("diaAtualSemanaServico", DataKind.R4, 4),
                        new TextLoader.Column("Label", DataKind.R4, 5)
                    }
                });

            IDataView trainingDataView = reader.Read(new MultiFileSource(dataPath));

            var pipeline = new TermEstimator(env, "Label", "Label")
                       .Append(new ConcatEstimator(env, "Features", "prioridade", "punicao", "dispensa", "ultimoDiaSemana", "diaAtualSemanaServico"))
                       .Append(new SdcaMultiClassTrainer(env, new SdcaMultiClassTrainer.Arguments()))
                       .Append(new KeyToValueEstimator(env, "PredictedLabel"));

            var model = pipeline.Fit(trainingDataView);            

            if (File.Exists(outputModel))
                File.Delete(outputModel);

            FileStream fs = File.Create(outputModel);

            model.SaveTo(env, fs);

            fs.Close();

        }
    }
}
