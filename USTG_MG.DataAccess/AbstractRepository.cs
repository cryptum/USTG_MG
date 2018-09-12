using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USTG_MG.DataAccess.Contextos;
using USTG_MG.Model;

namespace USTG_MG.DataAccess
{
    internal class AbstractRepository<T> : IRepositoryBase<T> where T : EntityBase, new()
    {
        private readonly USGTContext _context;
        public AbstractRepository(USGTContext context)
        {
            _context = context;
        }

        public void Excluir(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public T ObterNovoOuPor(int id)
        {
            if (id.Equals(0)) return new T();

            return _context.Set<T>().FirstOrDefault(p => p.Id.Equals(id));
        }

        public List<T> ObterTodos()
        {
            return _context.Set<T>().OrderByDescending(p => p.Id).AsNoTracking().ToList();
        }

        public void Salvar(T entity)
        {
            if (entity.Id.Equals(0))
                _context.Set<T>().Add(entity);
        }
    }
}
