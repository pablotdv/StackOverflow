using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapeamentoDataAnnotationApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    public class TesteContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }

    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }

        public int CidadeNatalId { get; set; }

        public int CidadeAtualId { get; set; }

        [ForeignKey("CidadeAtualId")]
        public virtual Cidade CidadeAtual { get; set; }

        [ForeignKey("CidadeNatalId")]
        public virtual Cidade CidadeNatal { get; set; }
    }


    [Table("Cidades")]
    public class Cidade
    {
        [Key]
        public int CidadeId { get; set; }

        public string Nome { get; set; }
                
        [InverseProperty("CidadeNatal")]
        public ICollection<Pessoa> PessoasCidadesNatal { get; set; }

        [InverseProperty("CidadeAtual")]
        public ICollection<Pessoa> PessoasCidadesAtual { get; set; }
    }
}
