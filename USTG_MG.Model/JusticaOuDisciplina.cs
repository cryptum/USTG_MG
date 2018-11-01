using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("JusticasOuDisciplinas")]
    public class JusticaOuDisciplina : EntityBase
    {
        public DateTime Data { get; set; }
        public string Observacao { get; set; }
        public Contingente Contingente { get; set; }
        public int ContingenteId { get; set; }
        public Acao Acao { get; set; }

        public void ComputarAcao()
        {
            if (Acao == Acao.Elogio)
                Contingente.ComputarElogios();
            else if (Acao == Acao.Punição)
                Contingente.ComputarPunicoes();
        }

        public override void Validar()
        {
            _DataDeveSerValida("Data", Data);
            _ObjetoNaoPodeSerNulo("Contingente", Contingente);
            _DataNaoPodeEstarNoFuturo("Data", Data);
            base.Validar();
        }
    }

    public interface IJusticaOuDisciplinaRepository : IRepositoryBase<JusticaOuDisciplina>
    {
        List<JusticaOuDisciplinaVM> ObterPor(int contingenteId);
        List<JusticaOuDisciplinaVM> ObterTodos(int turmaId);
        List<JusticaOuDisciplinaVM> ObterPorRA(string ra, int turmaId);
        List<JusticaOuDisciplinaVM> ObterPorNome(string nome, int turmaId);
        List<JusticaOuDisciplinaVM> ObterContigente(int contingenteId, Acao tipoAcao, DateTime data);
    }

    public enum Acao
    {
        Elogio = 1,
        Punição = 2
    }

    public class JusticaOuDisciplinaVM
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string NomeDeGuerra { get; set; }
        public string RA { get; set; }
        public string Patente { get; set; }
        public string Acao { get; set; }
        public string CadastradoPor { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Observacao { get; set; }
    }
}
