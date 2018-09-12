using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("Configuracoes")]
    public class Configuracao : EntityBase
    {
       
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }
        public int UsuarioId { get; set; }       
        public bool IniciarComContingenteAberto { get; set; }

        public override void Validar()
        {            
            _ObjetoNaoPodeSerNulo(nameof(Turma), Turma);
          
            base.Validar();
        }

    }

    public interface IConfiguracaoRepository : IRepositoryBase<Configuracao>
    {
        Configuracao ObterPor(int usuarioId);
    }
}
