using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeamentoFluentAPIRelacionamentos.Models
{
    public class CidadeMap : EntityTypeConfiguration<CidadeEntity>
    {
        public CidadeMap()
        {
            ToTable("Cidade");
            HasKey(c => c.Id);
            Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(120);
            //HasRequired(f => f.Estado).WithMany(p => p.CidadeLista).HasForeignKey(p => p.EstadoId);
        }
    }

    public class EstadoMap : EntityTypeConfiguration<EstadoEntity>
    {
        public EstadoMap()
        {
            ToTable("Estado");
            HasKey(c => c.Id);
            Property(p => p.Sigla).IsRequired().HasColumnType("char").HasMaxLength(5);
            Property(p => p.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(75);
            //Ignore(p => p.EstadoPaisId);
            //Relacionamentos
            HasRequired(p => p.CidadeLista).WithRequiredPrincipal().Map(p => p.MapKey("EstadoId"));
        }
    }

    public class PaisMap : EntityTypeConfiguration<PaisEntity>
    {
        public PaisMap()
        {
            ToTable("Pais");
            HasKey(c => c.Id);
            Property(p => p.Sigla)
                .HasColumnType("varchar")
                .HasMaxLength(5);
            Property(p => p.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(50);
        }
    }
}
