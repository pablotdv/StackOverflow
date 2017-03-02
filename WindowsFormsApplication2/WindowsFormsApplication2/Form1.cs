using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        List<Pessoa> list = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(new Pessoa(txt_ano.Text, txt_nome.Text, txt_endereco.Text, txt_tele.Text));

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }
    }

    public class Pessoa
    {
        private string nome;
        private string endereço;
        private string ano_nascimento;
        private string telefone;

        public string Nome
        {
            get
            {
                return nome;
            }

            private set
            {
                nome = value;
            }
        }

        public string Endereço
        {
            get
            {
                return endereço;
            }

            private set
            {
                endereço = value;
            }
        }

        public string Ano_nascimento
        {
            get
            {
                return ano_nascimento;
            }

            private set
            {
                ano_nascimento = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            private set
            {
                telefone = value;
            }
        }

        public Pessoa(string nome, string endereço, string ano_nascimento, string telefone)
        {
            this.nome = nome;

            this.endereço = endereço;

            this.ano_nascimento = ano_nascimento;

            this.telefone = telefone;

        }
    }
}
