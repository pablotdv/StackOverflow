using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeamentoFluentAPIRelacionamentos.Models
{
    public class ExemploContext : DbContext
    {
        public DbSet<EstadoEntity> Estados { get; set; }

        public DbSet<CidadeEntity> Cidades { get; set; }

        public DbSet<PaisEntity> Paises { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EstadoMap());
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new PaisMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
