using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxDB.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        public string Descricao { get; set; }

        public int ProdutoGrupoId { get; set; }

        public virtual ProdutoGrupo ProdutoGrupo { get; set; }
    }
}
