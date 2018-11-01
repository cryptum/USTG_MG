
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USTG_MG.DataAccess.Mapeamentos;
using USTG_MG.Model;

namespace USTG_MG.DataAccess.Contextos
{
    internal class USGTContext : DbContext
    {
        public USGTContext() : base("DefaultConnection")
        {            
            Database.SetInitializer<USGTContext>(new MigrateDatabaseToLatestVersion<USGTContext, ConfiguraContexto>());
        }       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Aqui restrição geral
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Properties().Configure(p => p.IsRequired());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(256));

            //Aqui liberação das execessões;
            modelBuilder.Configurations.Add(new TurmaMap());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AtividadeExtra> AtividadesExtras { get; set; }
        public DbSet<Contingente> Contingentes { get; set; }
        public DbSet<ContingenteFoto> ContingentesFotos { get; set; }
        public DbSet<Escolaridade> Escolaridades { get; set; }
        public DbSet<FaltaOuAtraso> FaltasOuAtrasos { get; set; }
        public DbSet<HoraExtra> HorasExtras { get; set; }
        public DbSet<Profissao> Profissoes { get; set; }
        public DbSet<JusticaOuDisciplina> JusticasOuDisciplinas { get; set; }
        public DbSet<Patente> Patentes { get; set; }
        public DbSet<Religiao> Religioes { get; set; }
        public DbSet<TAF> Tafs { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Configuracao> Configuracoes { get; set; }
        public DbSet<Servico> Servicos { get; set; }
    }
}
