using ExemploTypeaheadMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploTypeaheadMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [OutputCache(Location = System.Web.UI.OutputCacheLocation.None)]

        public JsonResult PesquisarPorNome(string nome)
        {
            var nomes = String.IsNullOrEmpty(nome) ? new string[0] : nome.Split(' ');

            var dados = Pessoas().Where(b => nomes.All(c => b.Nome.Contains(c)))
                .Select(a => new
                {
                    Id = a.Id,
                    value = a.Nome,
                }).ToList();

            return Json(dados, JsonRequestBehavior.AllowGet);

        }

        private List<Pessoa> Pessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa() { Id = 1, Nome = "Pablo" });
            pessoas.Add(new Pessoa() { Id = 2, Nome = "Lucas" });
            pessoas.Add(new Pessoa() { Id = 3, Nome = "Aline" });
            pessoas.Add(new Pessoa() { Id = 4, Nome = "Beth" });
            return pessoas;
        }
    }
}