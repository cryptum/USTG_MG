using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("Servico")]
    public class Servico: EntityBase
    {
        public TipoServico Tipo { get; set; }
        public int FlagPermanencia { get; set; }
        public DateTime Data { get; set; }
        public List<Contingente> Contigentes { get; set; }
    }

    public enum TipoServico
    {
        Preta = 0,
        Vermelha = 1
    }

    public interface IServicoRepository : IRepositoryBase<Servico>
    {
        List<ServicoVM> obterUltimoPor(int contigenteId);
        List<ServicoVM> obterUltimoPor(int contigenteId, int tipoServico);
        ServicoVM obterUltimoPor(DateTime data);
    }

    public class ServicoVM
    {
        public int Id { get; set; }
        public TipoServico Tipo { get; set; }
        public int FlagPermanencia { get; set; }
        public DateTime Data { get; set; }
        public List<ContingenteVM> Contigentes { get; set; }
        public string CadastradoPor { get; set; }
        public DateTime DataCadastro { get; set; }
    }

}
