using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USTG_MG.DataAccess.Contextos
{   
    internal sealed class ConfiguraContexto : DbMigrationsConfiguration<USGTContext>
    {
        public ConfiguraContexto()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
