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
    internal class PatenteRepository:AbstractRepository<Patente>, IPatenteRepository
    {
        private readonly USGTContext _context;
        public PatenteRepository(USGTContext context):base(context)
        {
            _context = context;
        }

        public new List<Patente> ObterTodos()
        {
            return _context.Patentes
                           .OrderBy(p => p.Descricao)
                           .AsNoTracking()
                           .ToList();
        }

    }
}
