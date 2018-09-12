using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("AtividadesExtras")]
    public class AtividadeExtra : EntityBase
    {
        public string Descricao { get; set; }

        public override void Validar()
        {
            
            _CampoObrigatorio("Descrição", Descricao);
            base.Validar();
        }
    }

    public interface IAtividadeExtraRepository : IRepositoryBase<AtividadeExtra> { }
}
