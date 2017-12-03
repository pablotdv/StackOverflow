using AgruparItensEmTabelaAplicacaoASPNETWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgruparItensEmTabelaAplicacaoASPNETWebMVC.Controllers
{
    public class HomeController : Controller
    {
        List<PesquisaProduto> dados;
        public HomeController()
        {
            dados = new List<PesquisaProduto>() {
                new PesquisaProduto(){ CodPro = 1, Nome = "Produto 1" },
                new PesquisaProduto(){ CodPro = 1, Nome = "Produto 1" },
                new PesquisaProduto(){ CodPro = 1, Nome = "Produto 1" },
                new PesquisaProduto(){ CodPro = 2, Nome = "Produto 2" },
                new PesquisaProduto(){ CodPro = 3, Nome = "Produto 3" },
                new PesquisaProduto(){ CodPro = 2, Nome = "Produto 2" },
                new PesquisaProduto(){ CodPro = 4, Nome = "Produto 4" },
                new PesquisaProduto(){ CodPro = 4, Nome = "Produto 4" },
            };
        }

        public ActionResult Index()
        {
            var pesquisa = dados.GroupBy(a => a.CodPro);
            return View(pesquisa);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}