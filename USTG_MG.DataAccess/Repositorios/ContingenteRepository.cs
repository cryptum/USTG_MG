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
    internal class ContingenteRepository : AbstractRepository<Contingente>, IContingenteRepository
    {
        private readonly USGTContext _context;
        public ContingenteRepository(USGTContext context) : base(context)
        {
            _context = context;
        }

        public List<ContingenteVM> ObterTodos(int turmaId)
        {
            var query = _context.Contingentes
                                      .Include(p => p.Patente)
                                      .Include(p => p.Turma)
                                      .Where(p => p.TurmaId.Equals(turmaId))
                                      .OrderBy(p => p.RA)
                                      .AsNoTracking()
                                      .ToList();

            return query.ConvertToVM();
        }

        public new Contingente ObterNovoOuPor(int id)
        {
            if (id.Equals(0)) return new Contingente();

            return _context.Contingentes.Include(p => p.Fotos)
                                        .Include(p => p.Patente)
                                        .FirstOrDefault(p => p.Id.Equals(id));
        }

        public  List<ContingenteVM> ObterPorNome(string nome, int turmaId)
        {
            var query = _context.Contingentes
                                      .Include(p => p.Patente)
                                      .Include(p => p.Turma)
                                      .Where(p => p.NomeDeGuerra.StartsWith(nome) &&
                                             p.TurmaId.Equals(turmaId))
                                      .OrderBy(p => p.RA)
                                      .AsNoTracking()
                                      .ToList();

            return query.ConvertToVM();
        }

        public List<ContingenteVM> ObterPorRA(string ra, int turmaId)
        {
            var query =  _context.Contingentes
                                      .Include(p => p.Patente)
                                      .Include(p => p.Turma)
                                      .Where(p => p.RA.StartsWith(ra) &&
                                             p.TurmaId.Equals(turmaId))
                                      .OrderBy(p => p.RA)
                                      .AsNoTracking()
                                      .ToList();

            return query.ConvertToVM();            
        }

        public List<ContingenteVM> ObterTodosAtivos(int turmaId)
        {
            var query = _context.Contingentes
                                      .Include(p => p.Patente)
                                      .Include(p => p.Turma)
                                      .Where(p => p.TurmaId.Equals(turmaId)
                                       && ((int)p.Status).Equals((int)StatusDoMilitar.Ativo))
                                      .AsNoTracking()
                                      .ToList();

            return query.ConvertToVM();
        }

        public List<ContingenteVM> ObterTodosAtivos(int turmaId, int patenteId)
        {
            var query = _context.Contingentes
                                      .Include(p => p.Patente)
                                      .Include(p => p.Turma)
                                      .Where(p => p.TurmaId.Equals(turmaId)
                                            && ((int)p.Status).Equals((int)StatusDoMilitar.Ativo)
                                            && p.PatenteId.Equals(patenteId))
                                      .AsNoTracking()
                                      .ToList();

            return query.ConvertToVM();
        }
    }
}
