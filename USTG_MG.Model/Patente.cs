using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("Patentes")]
    public class Patente: EntityBase
    {
        public string Descricao { get; set; }

        public override void Validar()
        {
            _CampoObrigatorio("Descrição", Descricao);
            base.Validar();
        }
    }

    public interface IPatenteRepository : IRepositoryBase<Patente> { }


}
