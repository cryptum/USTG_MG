using System.Collections.Generic;

namespace USTG_MG.Model
{
    public static class MetodosDeExtensao
    {
        public static List<ContingenteVM> ConvertToVM(this List<Contingente> lista)
        {
            var novaLista = new List<ContingenteVM>();

            if( !(lista is null) )
            { 
                foreach (var item in lista)
                {
                    novaLista.Add(item.ConvertToVM());
                }
            }
            return novaLista;
        }

        public static ContingenteVM ConvertToVM(this Contingente item)
        {
            return new ContingenteVM()
            {
                Id = item.Id,
                NomeDeGuerra = item.NomeDeGuerra,
                Atrasos = item.Atrasos,
                Elogios = item.Elogios,
                Faltas = item.Faltas,
                HorasExtras = item.HorasExtras,
                Patente = item.Patente.Descricao,
                Punicoes = item.Punicoes,
                RA = item.RA,
                Status = item.Status.ToString(),
                Turma = item.Turma.ANO
            };


        }

        public static List<FaltaOuAtrasoVM> ConvertToVM(this List<FaltaOuAtraso> lista)
        {
            var novaLista = new List<FaltaOuAtrasoVM>();

            foreach (var item in lista)
            {
                novaLista.Add(item.ConvertToVM());
            }

            return novaLista;
        }

        public static FaltaOuAtrasoVM ConvertToVM(this FaltaOuAtraso item)
        {
            return new FaltaOuAtrasoVM()
            {
                Id = item.Id,
                NomeDeGuerra = item.Contingente.NomeDeGuerra,
                RA = item.Contingente.RA,
                Patente = item.Contingente.Patente.Descricao,
                Data = item.Data.ToShortDateString(),
                Situacao = item.Situacao.ToString(),
                CadastradoPor = item.CadastradoPor,
                DataCadastro = item.DataCadastro,
                Observacao = item.Observacao
            };
        }

        public static List<JusticaOuDisciplinaVM> ConvertToVM(this List<JusticaOuDisciplina> lista)
        {
            var novaLista = new List<JusticaOuDisciplinaVM>();

            foreach (var item in lista)
            {
                novaLista.Add(item.ConvertToVM());
            }

            return novaLista;
        }

        public static JusticaOuDisciplinaVM ConvertToVM(this JusticaOuDisciplina item)
        {
            return new JusticaOuDisciplinaVM()
            {
                Id = item.Id,
                NomeDeGuerra = item.Contingente.NomeDeGuerra,
                RA = item.Contingente.RA,
                Patente = item.Contingente.Patente.Descricao,
                Data = item.Data.ToShortDateString(),
                Acao = item.Acao.ToString(),
                CadastradoPor = item.CadastradoPor,
                DataCadastro = item.DataCadastro,
                Observacao = item.Observacao

            };


        }

        public static List<HoraExtraVM> ConvertToVM(this List<HoraExtra> lista)
        {
            var novaLista = new List<HoraExtraVM>();
            foreach (var item in lista)
            {
                novaLista.Add(item.ConvertToVM());
            }

            return novaLista;
        }

        public static HoraExtraVM ConvertToVM(this HoraExtra item)
        {
            return new HoraExtraVM()
            {
                Id = item.Id,
                NomeDeGuerra = item.Contingente.NomeDeGuerra,
                Patente = item.Contingente.Patente.Descricao,
                RA = item.Contingente.RA,
                Data = item.Data.ToShortDateString(),
                Atividade = item.Atividade.Descricao.ToString(),
                CadastradoPor = item.CadastradoPor,
                DataCadastro = item.DataCadastro,
                Observacao = item.Observacoes,
                QtdHoras = item.QtdHoras.ToString()

            };


        }

        public static List<TAFVM> ConvertToVM(this List<TAF> lista)
        {
            var novaLista = new List<TAFVM>();
            foreach (var item in lista)
            {
                novaLista.Add(item.ConvertToVM());
            }

            return novaLista;
        }

        public static TAFVM ConvertToVM(this TAF item)
        {
            return new TAFVM()
            {
                Id = item.Id,
                NomeDeGuerra = item.Contingente.NomeDeGuerra,
                Patente = item.Contingente.Patente.Descricao,
                RA = item.Contingente.RA,
                Data = item.Data.ToShortDateString(),
                Abdominais = item.Abdominais,
                Barras = item.Barras,
                Corrida = item.Corrida12Min,
                Flexoes = item.Flexoes,               
                Nota = item.Nota

            };


        }

        public static ServicoVM ConvertToVM(this Servico item)
        {
            return new ServicoVM()
            {

                Id = item.Id,
                Tipo = item.Tipo,
                FlagPermanencia = item.FlagPermanencia,
                Data = item.Data,
                Contigentes = MetodosDeExtensao.ConvertToVM(item.Contigentes),
                CadastradoPor = item.CadastradoPor,
                DataCadastro = item.DataCadastro
            };
        }

        public static List<ServicoVM> ConvertToVM(this List<Servico> lista)
        {
            var novaLista = new List<ServicoVM>();
            foreach (var item in lista)
            {
                novaLista.Add(item.ConvertToVM());
            }

            return novaLista;
        }

    }
}
