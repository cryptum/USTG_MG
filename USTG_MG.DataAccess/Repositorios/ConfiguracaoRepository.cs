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
    internal class ConfiguracaoRepository:AbstractRepository<Configuracao>, IConfiguracaoRepository
    {
        private readonly USGTContext _context;
        public ConfiguracaoRepository(USGTContext context):base(context)
        {
            _context = context;
        }

        public Configuracao ObterPor(int usuarioId)
        {
            return _context.Configuracoes
                           .Include(p => p.Turma)
                           .FirstOrDefault(p => p.UsuarioId.Equals(usuarioId));
        }
    }

}
