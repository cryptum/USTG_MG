using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("Usuarios")]
    public class Usuario : EntityBase
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        [NotMapped]
        public string ConfirmaSenha { get; set; }

        public List<Configuracao> Configuracoes { get; set; }

        public override void Validar()
        {
            _CampoObrigatorio(nameof(Nome), Nome);
            _CampoObrigatorio(nameof(Senha), Senha);
            _CampoObrigatorio("Confirma Senha", ConfirmaSenha);

            if (!Senha.Equals(ConfirmaSenha))
                _RegrasQuabradas.Append($"senha e confirma senha não conferem.{Environment.NewLine}");

            base.Validar();
        }
    }

    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        Usuario ObterPor(int id);
        Usuario ObterPor(string usuario, string senha);
    }
}
