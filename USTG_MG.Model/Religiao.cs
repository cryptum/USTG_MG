using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("Religioes")]
    public class Religiao : EntityBase
    {
        public string Descricao { get; set; }      

        public override void Validar()
        {
            _CampoObrigatorio("Descrição", Descricao);
            base.Validar();
        }
    }

    public interface IReligiaoRepository : IRepositoryBase<Religiao>
    {
        
    }

   
}
