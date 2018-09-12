using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("TAFs")]
    public class TAF : EntityBase
    {
        public Contingente Contingente { get; set; }
        public int ContingenteId { get; set; }
        public DateTime Data { get; set; }
        public string Flexoes { get; set; }
        public string Barras { get; set; }
        public string Abdominais { get; set; }
        public string Corrida12Min { get; set; }
        public string Nota { get; set; }
        public string Observacao { get; set; }

        public override void Validar()
        {
            _ObjetoNaoPodeSerNulo(nameof(Contingente), Contingente);
            _DataDeveSerValida(nameof(Data), Data);
            _DataNaoPodeEstarNoFuturo("Data", Data);
            _CampoObrigatorio(nameof(Flexoes), Flexoes);
            _CampoObrigatorio(nameof(Barras), Barras);
            _CampoObrigatorio(nameof(Abdominais), Abdominais);
            _CampoObrigatorio("Corrida", Corrida12Min);
            _CampoObrigatorio(nameof(Nota), Nota);

            base.Validar();
        }
    }

    public interface ITAFRepository : IRepositoryBase<TAF>
    {
        List<TAFVM> ObterTodos(int turmaId);
        List<TAFVM> ObterPorRA(string ra, int turmaId);
        List<TAFVM> ObterPorNome(string nome, int turmaId);
        List<TAFVM> ObterPor(int ContingenteId);
    }

    public class TAFVM
    {
        public int Id { get; set; }        
        public string RA { get; set; }
        public string NomeDeGuerra { get; set; }
        public string Patente { get; set; }
        public string Data { get; set; }
        public string Flexoes { get; set; }
        public string Barras { get; set; }
        public string Abdominais { get; set; }
        public string Corrida { get; set; }
        public string Nota { get; set; }
    }
}
