using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USTG_MG.DataAccess.Contextos;
using USTG_MG.Model;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace USTG_MG.DataAccess.Repositorios
{
    internal class ServicoRepository : AbstractRepository<Servico>, IServicoRepository
    {
        private readonly USGTContext _context;
        public ServicoRepository(USGTContext context) : base(context)
        {
            _context = context;
        }

        public List<ServicoVM> obterUltimoPor(int contigenteId)
        {
            var query = _context.Servicos
                        .Include(p => p.Contigentes)
                        .Where(p => p.Contigentes.Any(c => c.Id.Equals(contigenteId)))
                        .OrderByDescending(p => p.Data)
                        .ToList();

            return query.ConvertToVM();
        }

        public List<ServicoVM> obterUltimoPor(int contigenteId, int tipoServico)
        {
            var query = _context.Servicos
                        .Include(p => p.Contigentes)
                        .Include(p => p.Contigentes.Select(c => c.Turma))
                        .Include(p => p.Contigentes.Select(c => c.Patente))
                        .Where(p => p.Contigentes.Any(c => c.Id.Equals(contigenteId)))
                        .Where(p => ((int)p.Tipo) == tipoServico)
                        .OrderByDescending(p => p.Data)
                        .ToList();

            return query.ConvertToVM();
        }

        public ServicoVM obterUltimoPor(DateTime data)
        {
            var query = _context.Servicos
                        .Include(p => p.Contigentes)
                        .Include(p => p.Contigentes.Select(c => c.Turma))
                        .Include(p => p.Contigentes.Select(c => c.Patente))
                        .Where(p => DbFunctions.DiffDays(p.Data, data) == 0)
                        .OrderByDescending(p => p.Data);

            if (query.Count() > 0) 
                return query.First().ConvertToVM();
            else
                return null;
        }
    }
}
