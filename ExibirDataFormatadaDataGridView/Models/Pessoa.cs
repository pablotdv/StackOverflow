using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExibirDataFormatadaDataGridView.Models
{
    public class Pessoa
    {
        public DateTime DataHora { get; internal set; }
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
    }
}
