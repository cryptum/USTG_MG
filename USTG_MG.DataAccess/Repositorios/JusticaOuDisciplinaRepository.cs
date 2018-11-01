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
    internal class JusticaOuDisciplinaRepository : AbstractRepository<JusticaOuDisciplina>, IJusticaOuDisciplinaRepository
    {
        private readonly USGTContext _context;
        public JusticaOuDisciplinaRepository(USGTContext context) : base(context)
        {
            _context = context;
        }

        public List<JusticaOuDisciplinaVM> ObterPor(int contingenteId)
        {
            var query = _context.JusticasOuDisciplinas
                                .Include(p => p.Contingente)
                                .Include(p => p.Contingente.Patente)
                                .Where(p => p.ContingenteId.Equals(contingenteId))
                                .AsNoTracking()
                                .ToList();

            return query.ConvertToVM();
        }

        public List<JusticaOuDisciplinaVM> ObterContigente(int contingenteId, Acao tipoAcao, DateTime data)
        {

            var query = _context.JusticasOuDisciplinas
                                .Include(p => p.Contingente)
                                .Include(p => p.Contingente.Patente)
                                .Where(p => p.ContingenteId.Equals(contingenteId) 
                                        && p.Data.Equals(data)
                                        && ((int)p.Acao).Equals((int)tipoAcao))
                                .AsNoTracking()
                                .ToList();

            return query.ConvertToVM();

        }

        public List<JusticaOuDisciplinaVM> ObterPorNome(string nome, int turmaId)
        {
            var query = _context.JusticasOuDisciplinas
                               .Include(p => p.Contingente)
                               .Include(p => p.Contingente.Patente)
                               .Where(p => p.Contingente.NomeDeGuerra.StartsWith(nome) &&
                                      p.Contingente.TurmaId.Equals(turmaId))
                                      .OrderBy(p => p.Contingente.RA)
                                 .ThenBy(p => p.Data)
                               .AsNoTracking()
                               .ToList();

            return query.ConvertToVM();
        }

        public List<JusticaOuDisciplinaVM> ObterPorRA(string ra, int turmaId)
        {
            var query = _context.JusticasOuDisciplinas
                              .Include(p => p.Contingente)
                              .Include(p => p.Contingente.Patente)
                              .Where(p => p.Contingente.RA.StartsWith(ra) &&
                                     p.Contingente.TurmaId.Equals(turmaId))
                              .OrderBy(p => p.Contingente.RA)
                              .ThenBy(p => p.Data)
                              .AsNoTracking()
                              .ToList();

            return query.ConvertToVM();
        }

        public List<JusticaOuDisciplinaVM> ObterTodos(int turmaId)
        {
            var query = _context.JusticasOuDisciplinas
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
