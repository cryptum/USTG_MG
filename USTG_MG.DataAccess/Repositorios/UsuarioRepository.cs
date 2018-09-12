using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USTG_MG.DataAccess.Contextos;
using USTG_MG.Model;
using System.Data.Entity;

namespace USTG_MG.DataAccess.Repositorios
{
    internal class UsuarioRepository : AbstractRepository<Usuario>, IUsuarioRepository
    {
        private readonly USGTContext _context;
        public UsuarioRepository(USGTContext context) : base(context)
        {
            _context = context;
        }

        public Usuario ObterPor(int id)
        {
            return _context.Usuarios.FirstOrDefault(p => p.Id.Equals(id));
        }

        public Usuario ObterPor(string usuario, string senha)
        {
            return _context.Usuarios
                           .Include(p => p.Configuracoes)
                           .FirstOrDefault(p => p.Nome.Equals(usuario) &&
                                           p.Senha.Equals(senha));
        }

        public new List<Usuario> ObterTodos()
        {
            return _context.Usuarios
                           .OrderBy(p => p.Nome)
                           .AsNoTracking()
                           .ToList();
        }
    }
}
