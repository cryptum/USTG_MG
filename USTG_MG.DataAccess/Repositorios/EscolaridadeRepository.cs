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
    internal class EscolaridadeRepository : AbstractRepository<Escolaridade>, IEscolaridadeRepository
    {
        private readonly USGTContext _context;
        public EscolaridadeRepository(USGTContext context) : base(context)
        {
            _context = context;
        }

        public new List<Escolaridade> ObterTodos()
        {
            return _context.Escolaridades
                           .OrderBy(p => p.Descricao)
                           .AsNoTracking()
                           .ToList();
        }
    }
}
