using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("ContingentesFotos")]
    public class ContingenteFoto:EntityBase
    {
        public int ContingenteId { get; set; }
        public byte[] Binario { get; set; }
        public string Extensao { get; set; }
        public string NomeArquivo { get; set; }        
    }

    public interface IContingenteFotoRepository : IRepositoryBase<ContingenteFoto> { }
}
