using ExibirDataFormatadaDataGridView.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            var dt = GetDataSet("select * from cc.Pessoa");

            BindingSource sbind = new BindingSource();
            sbind.DataSource = dt;

            dataGridView1.DataSource = sbind;
            dataGridView1.Refresh();
        }

        public DataSet GetDataSet(string SQL)
        {
            DataSet ds = new DataSet();
            using (SqlCommand cmd = new SqlCommand(
                SQL, new SqlConnection("Data Source=.;Initial Catalog=GaveteiroLanches;Integrated Security=True")))
            {
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }
            return ds;
        }


    }

    public class PessoaList : BindingList<Pessoa>
    {


    }
}
