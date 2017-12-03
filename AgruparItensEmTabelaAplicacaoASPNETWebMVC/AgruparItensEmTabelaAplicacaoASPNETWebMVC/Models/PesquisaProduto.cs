using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgruparItensEmTabelaAplicacaoASPNETWebMVC.Models
{
    public class PesquisaProduto
    {
        public int CodPro { get; set; }
        public string CodBar { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public decimal Qtd { get; set; }
        public decimal Total { get; set; }
        public bool Confimado { get; set; }
        public DateTime DataPesquisa { get; set; }
    }
}