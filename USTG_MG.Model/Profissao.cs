using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("Profissoes")]
   public class Profissao:EntityBase 
    {
        public string Descricao { get; set; }

        public override void Validar()
        {
            _CampoObrigatorio(nameof(Descricao), Descricao);
            base.Validar();
        }
    }

    public interface IProfissaoRepository : IRepositoryBase<Profissao> { }

   
}
