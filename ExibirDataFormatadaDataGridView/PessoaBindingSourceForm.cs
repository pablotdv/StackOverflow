using ExibirDataFormatadaDataGridView.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExibirDataFormatadaDataGridView
{
    public partial class PessoaBindingSourceForm : Form
    {
        public PessoaBindingSourceForm()
        {
            InitializeComponent();
        }

        private void PessoaBindingSourceForm_Load(object sender, EventArgs e)
        {
            PessoaList list = new PessoaList();

            list.Add(new Pessoa() { Id = 1, DataHora = DateTime.Now.AddDays(1), Nome = "Pablo" });
            list.Add(new Pessoa() { Id = 2, DataHora = DateTime.Now.AddDays(2), Nome = "Pablo" });
            list.Add(new Pessoa() { Id = 3, DataHora = DateTime.Now.AddDays(3), Nome = "Pablo" });
            list.Add(new Pessoa() { Id = 4, DataHora = DateTime.Now.AddDays(4), Nome = "Pablo" });

            BindingSource sbind = new BindingSource();
            sbind.DataSource = list;
            dataGridView1.DataSource = sbind;
            dataGridView1.Refresh();
        }
    }

    public class PessoaList : BindingList<Pessoa>
    {

        
    }
}
