using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("HorasExtras")]
    public class HoraExtra: EntityBase
    {
        public DateTime Data { get; set; }
        public AtividadeExtra Atividade { get; set; }
        public int AtividadeExtraId { get; set; }
        public Contingente Contingente { get; set; }
        public int ContingenteId { get; set; }
        public int QtdHoras { get; set; }
        public string Observacoes { get; set; }

        public override void Validar()
        {
            if (QtdHoras < 1)
                _RegrasQuabradas.Append($"A quantidade de horas não pode ser menor que 1.{Environment.NewLine}");

            _DataDeveSerValida("Data", Data);
            _ObjetoNaoPodeSerNulo("Atividade Extra", Atividade);
            _ObjetoNaoPodeSerNulo("Contingente", Contingente);
            _DataNaoPodeEstarNoFuturo("Data", Data);
            base.Validar();
        }

        public void ComputarAcao()
        {
            Contingente.ComputarHorasExtras(QtdHoras);
        }
    }

    public interface IHoraExtraRepository : IRepositoryBase<HoraExtra>
    {
        List<HoraExtraVM> ObterPor(int contingenteId);
        List<HoraExtraVM> ObterTodos(int turmaId);
        List<HoraExtraVM> ObterPorRA(string ra, int turmaId);
        List<HoraExtraVM> ObterPorNome(string nome, int turmaId);
    }

    public class HoraExtraVM
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string NomeDeGuerra { get; set; }
        public string RA { get; set; }
        public string Patente { get; set; }
        public string Atividade { get; set; }
        public string QtdHoras { get; set; }
        public string Observacao { get; set; }
        public string CadastradoPor { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
