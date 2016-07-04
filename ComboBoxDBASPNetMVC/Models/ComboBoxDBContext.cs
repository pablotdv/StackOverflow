using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxDB.Models
{
    public class ComboBoxDBContext : DbContext
    {
        public ComboBoxDBContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<ProdutoGrupo> ProdutoGrupos { get; set; }
    }
}
