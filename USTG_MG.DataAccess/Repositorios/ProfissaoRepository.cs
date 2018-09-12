using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USTG_MG.DataAccess.Contextos;
using USTG_MG.Model;

namespace USTG_MG.DataAccess.Repositorios
{
   internal class ProfissaoRepository : AbstractRepository<Profissao>, IProfissaoRepository
    {
        private readonly USGTContext _context;
        public ProfissaoRepository(USGTContext contexto):base(contexto)
        {
            _context = contexto;
        }

        public new List<Profissao> ObterTodos()
        {
            return _context.Profissoes
                           .OrderBy(p => p.Descricao)
                           .AsNoTracking()
                           .ToList();
        }
    }
}
