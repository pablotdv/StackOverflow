using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ExemploContext())
            {
                context.VendaModel.Add(new VendaModel() {
                    cnpj_filial = "11.111.111/0001-11",
                    barras = "1236"
                });
                context.SaveChanges();

                string[] filiais = { "11.111.111/0001-11", "11.111.111/0001-12", "11.111.111/0001-15" };
                var retorno = (from ven in context.VendaModel
                               where filiais.Contains(ven.cnpj_filial)
                               select new
                               {
                                   ven.barras,
                                   ven.data,
                                   ven.valor
                               }).ToList();

                foreach(var r in retorno)
                {
                    Console.WriteLine(r.barras);
                }
            }
        }
    }

    public class ExemploContext : DbContext
    {
        public DbSet<VendaModel> VendaModel { get; set; }
    }

    [Table("venda")]
    public class VendaModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_vendas { get; set; }
        public string cpf { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
        public string barras { get; set; }
        public string valor { get; set; }
        public string qtde { get; set; }
        public int cupom { get; set; }
        public string cnpj_filial { get; set; }
        public string cnpj_matriz { get; set; }
    }
}
