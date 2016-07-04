using ComboBoxDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ComboBoxDBContext context = new ComboBoxDBContext())
            {
                comboBox1.DataSource = context.ProdutoGrupos.ToList();
                comboBox1.ValueMember = "ProdutoGrupoId";
                comboBox1.DisplayMember = "Descricao";
                comboBox1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ComboBoxDBContext context = new ComboBoxDBContext())
            {
                Produto produto = new Produto();
                produto.ProdutoGrupoId = Convert.ToInt32(comboBox1.SelectedValue);
                produto.Descricao = textBox1.Text;
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }
    }
}
