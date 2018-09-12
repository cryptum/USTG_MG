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
    internal class HoraExtraRepository : AbstractRepository<HoraExtra>, IHoraExtraRepository
    {
        private readonly USGTContext _context;
        public HoraExtraRepository(USGTContext context) : base(context)
        {
            _context = context;
        }

        public List<HoraExtraVM> ObterPor(int contingenteId)
        {
            var query = _context.HorasExtras
                                .Include(p => p.Atividade)
                                .Include(p => p.Contingente)
                                .Include(p => p.Contingente.Patente)
                                .Where(p => p.ContingenteId.Equals(contingenteId))
                                .AsNoTracking()
                                .ToList();

            return query.ConvertToVM();
        }

        public List<HoraExtraVM> ObterPorNome(string nome, int turmaId)
        {
            var query = _context.HorasExtras
                              .Include(p => p.Atividade)
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

        public List<HoraExtraVM> ObterPorRA(string ra, int turmaId)
        {
            var query = _context.HorasExtras
                               .Include(p => p.Atividade)
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

        public List<HoraExtraVM> ObterTodos(int turmaId)
        {
            var query = _context.HorasExtras
                               .Include(p => p.Atividade)
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
