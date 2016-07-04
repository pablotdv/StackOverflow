using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComboBoxDB.Models
{
    public class ProdutoGrupo
    {
        [Key]
        public int ProdutoGrupoId { get; set; }

        [Required]
        public string Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}