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
    internal class TAFRepository : AbstractRepository<TAF>, ITAFRepository
    {
        private readonly USGTContext _context;
        public TAFRepository(USGTContext context) : base(context)
        {
            _context = context;
        }

        public List<TAFVM> ObterPor(int ContingenteId)
        {
            var query = _context.Tafs
                              .Include(p => p.Contingente)
                              .Include(p => p.Contingente.Patente)
                              .Where(p => p.ContingenteId.Equals(ContingenteId))
                              .AsNoTracking()
                              .ToList();

            return query.ConvertToVM();
        }

        public List<TAFVM> ObterPorNome(string nome, int turmaId)
        {
            var query = _context.Tafs
                              .Include(p => p.Contingente)
                              .Include(p => p.Contingente.Patente)
                              .Where(p => p.Contingente.TurmaId.Equals(turmaId) &&
                                     p.Contingente.NomeDeGuerra.StartsWith(nome))
                              .OrderBy(p => p.Contingente.RA)
                              .ThenBy(p => p.Data)
                              .AsNoTracking()
                              .ToList();

            return query.ConvertToVM();
        }

        public List<TAFVM> ObterPorRA(string ra, int turmaId)
        {
            var query = _context.Tafs
                              .Include(p => p.Contingente)
                              .Include(p => p.Contingente.Patente)
                              .Where(p => p.Contingente.TurmaId.Equals(turmaId) &&
                                     p.Contingente.RA.StartsWith(ra))
                              .OrderBy(p => p.Contingente.RA)
                              .ThenBy(p => p.Data)
                              .AsNoTracking()
                              .ToList();

            return query.ConvertToVM();
        }

        public List<TAFVM> ObterTodos(int turmaId)
        {
            var query = _context.Tafs
                               .Include(p => p.Contingente)
                               .Include(p => p.Contingente.Patente)
                               .Where(p => p.Contingente.TurmaId.Equals(turmaId))
                               .OrderBy(p => p.Contingente.RA)
                               .ThenBy(p => p.Data)
                               .AsNoTracking()
                               .ToList();

            return query.ConvertToVM();
        }
    }
}
