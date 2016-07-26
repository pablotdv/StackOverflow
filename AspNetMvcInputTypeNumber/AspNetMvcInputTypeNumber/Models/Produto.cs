using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication24.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public decimal Quantidade { get; set; }

        public decimal? ValorCusto { get; set; }
    }
}