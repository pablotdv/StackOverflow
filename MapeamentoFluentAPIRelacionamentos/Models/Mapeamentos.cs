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

            HasRequired(a => a.Estado).WithMany(a => a.CidadeLista).HasForeignKey(a => a.EstadoId);
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
            
            HasRequired(a => a.Pais).WithMany(a => a.EstadoLista).HasForeignKey(a => a.PaisId);
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
