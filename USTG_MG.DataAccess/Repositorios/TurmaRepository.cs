using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USTG_MG.DataAccess.Contextos;
using USTG_MG.Model;

namespace USTG_MG.DataAccess.Repositorios
{
    internal class TurmaRepository:AbstractRepository<Turma>, ITurmaRepository
    {
        public TurmaRepository(USGTContext context):base(context)
        {

        }
    }
}
