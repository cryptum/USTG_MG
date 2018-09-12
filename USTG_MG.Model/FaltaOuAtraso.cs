using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USTG_MG.Model
{
    [Table("FaltasOuAtrasos")]
    public class FaltaOuAtraso : EntityBase
    {        
        public DateTime Data { get; set; }
        public Contingente Contingente { get; set; }
        public int ContingenteId { get; set; }
        public Situacao Situacao { get; set; }
        public string Observacao { get; set; }

        public override void Validar()
        {
            _DataDeveSerValida(nameof(Data), Data);
            _ObjetoNaoPodeSerNulo("Contingente", Contingente);
            _DataNaoPodeEstarNoFuturo("Data", Data);
            base.Validar();
        }

        public void ComputarAcao()
        {
            if (Situacao == Situacao.Falta)
                Contingente.ComputarFalta();
            if (Situacao == Situacao.Atraso)
                Contingente.ComputarAtrasos();
        }
    }

    public interface IFaltaOuAtrasoRepository : IRepositoryBase<FaltaOuAtraso>
    {
        List<FaltaOuAtrasoVM> ObterPor(int contingenteId);
        List<FaltaOuAtrasoVM> ObterTodos(int turmaId);
        List<FaltaOuAtrasoVM> ObterPorRA(string ra, int turmaId);
        List<FaltaOuAtrasoVM> ObterPorNome(string nome, int turmaId);
    }

    public enum Situacao
    {
        Falta = 1,
        Atraso = 2
    }

    public class FaltaOuAtrasoVM
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string NomeDeGuerra { get; set; }
        public string RA { get; set; }
        public string Patente { get; set; }
        public string Situacao { get; set; }
        public string CadastradoPor { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Observacao { get; set; }
       

    }
}
