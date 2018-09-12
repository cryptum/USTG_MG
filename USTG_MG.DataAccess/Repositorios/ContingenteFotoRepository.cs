using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USTG_MG.DataAccess.Contextos;
using USTG_MG.Model;

namespace USTG_MG.DataAccess.Repositorios
{
    internal class ContingenteFotoRepository:AbstractRepository<ContingenteFoto>, IContingenteFotoRepository
    {
        public ContingenteFotoRepository(USGTContext context):base(context)
        {

        }
    }
}
