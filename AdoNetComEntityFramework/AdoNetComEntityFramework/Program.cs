using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetComEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            InserirDados();
            UsandoAdo();
            UsandoEF();
        }

        static void InserirDados()
        {
            using (EFContext ef = new EFContext())
            {
                if (!ef.Pessoas.Any())
                {
                    for (int i = 0; i < 10; i++)
                    {
                        ef.Pessoas.Add(new Pessoa() { Nome = $"Nome {i}" });
                    }

                    ef.SaveChanges();
                }
            }
        }

        static void UsandoAdo()
        {
            using (SqlConnection ado = new SqlConnection(ConfigurationManager.ConnectionStrings["EFContext"].ToString()))
            {
                string select = "select * from pessoas";
                SqlCommand command = new SqlCommand(select, ado);
                ado.Open();
                var dr = command.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine($"Usando ADO {dr["Nome"]}");
                }
            }
        }

        static void UsandoEF()
        {
            using (EFContext ef = new EFContext())
            {
                foreach(var pessoa in ef.Pessoas.ToList())
                {
                    Console.WriteLine($"Usando EF {pessoa.Nome}");
                }
            }
        }
    }

    public class EFContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }

    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
