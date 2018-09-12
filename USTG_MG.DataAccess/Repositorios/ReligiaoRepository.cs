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
    internal class ReligiaoRepository:AbstractRepository <Religiao>, IReligiaoRepository
    {
        private readonly USGTContext _context;
        public ReligiaoRepository(USGTContext context):base(context)
        {
            _context = context;
        }

        public new List<Religiao> ObterTodos()
        {
            return _context.Religioes
                           .OrderBy(p => p.Descricao)
                           .AsNoTracking()
                           .ToList();
        }

    }
}
