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
   internal class AtividadeExtraRepository : AbstractRepository<AtividadeExtra>, IAtividadeExtraRepository
    {
        private readonly USGTContext _context;
        public AtividadeExtraRepository(USGTContext context) : base(context)
        {
            _context = context;
        }

        public new List<AtividadeExtra> ObterTodos()
        {
            return _context.AtividadesExtras
                           .OrderBy(p => p.Descricao)
                           .AsNoTracking()
                           .ToList();
        }
    }
}
