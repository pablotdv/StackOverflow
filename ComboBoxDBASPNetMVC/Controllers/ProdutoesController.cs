using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ComboBoxDB.Models;

namespace ComboBoxDBASPNetMVC.Controllers
{
    public class ProdutoesController : Controller
    {
        private ComboBoxDBContext db = new ComboBoxDBContext();

        // GET: Produtoes
        public async Task<ActionResult> Index()
        {
            var produtos = db.Produtos.Include(p => p.ProdutoGrupo);
            return View(await produtos.ToListAsync());
        }

        // GET: Produtoes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = await db.Produtos.FindAsync(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produtoes/Create
        public ActionResult Create()
        {
            ViewBag.ProdutoGrupoId = new SelectList(db.ProdutoGrupos, "ProdutoGrupoId", "Descricao");
            return View();
        }

        // POST: Produtoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProdutoId,Descricao,ProdutoGrupoId")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Produtos.Add(produto);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ProdutoGrupoId = new SelectList(db.ProdutoGrupos, "ProdutoGrupoId", "Descricao", produto.ProdutoGrupoId);
            return View(produto);
        }

        // GET: Produtoes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = await db.Produtos.FindAsync(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProdutoGrupoId = new SelectList(db.ProdutoGrupos, "ProdutoGrupoId", "Descricao", produto.ProdutoGrupoId);
            return View(produto);
        }

        // POST: Produtoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProdutoId,Descricao,ProdutoGrupoId")] Produto produto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(produto).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ProdutoGrupoId = new SelectList(db.ProdutoGrupos, "ProdutoGrupoId", "Descricao", produto.ProdutoGrupoId);
            return View(produto);
        }

        // GET: Produtoes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = await db.Produtos.FindAsync(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produtoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Produto produto = await db.Produtos.FindAsync(id);
            db.Produtos.Remove(produto);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
