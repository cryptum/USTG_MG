using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USTG_MG.Model;

namespace USTG_MG.DataAccess.Mapeamentos
{
    internal class TurmaMap : EntityTypeConfiguration<Turma>
    {
        public TurmaMap()
        {
            Property(p => p.ANO).HasMaxLength(4);
        }
    }
}
