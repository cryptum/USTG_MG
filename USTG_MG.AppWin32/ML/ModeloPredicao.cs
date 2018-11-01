using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Runtime.Api;
using Microsoft.ML.Runtime.Data;
using Microsoft.ML.Runtime.Learners;

namespace USTG_MG.AppWin32.ML
{
    public class ModeloPredicao
    {
        [Column("0")]
        public float prioridade;
        [Column("1")]
        public float punicao;
        [Column("2")]
        public float dispensa;
        [Column("3")]
        public float ultimoDiaSemana;
        [Column("4")]
        public float diaAtualSemanaServico;
        [Column("5")]
        [ColumnName("Label")]
        public float Label;
    }

    public class ServicoPredicao
    {
        [ColumnName("PredictedLabel")]
        public float PredictedLabels;
    }



}
