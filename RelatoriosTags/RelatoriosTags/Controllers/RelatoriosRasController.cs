using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RelatoriosTags.Models;

namespace RelatoriosTags.Controllers
{
    public class RelatoriosRasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RelatoriosRas
public async Task<ActionResult> Index(int? tagId)
{
    var relatorioRaModels = db.RelatoriosRas.Include(r => r.RelatorioTag);
            
    if (tagId.HasValue)
    {
        //realiza o filtro para a tag selecionada
        relatorioRaModels = relatorioRaModels.Where(a => a.TagID == tagId);
    }

    return View(await relatorioRaModels.ToListAsync());
}

        // GET: RelatoriosRas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatorioRaModels relatorioRaModels = await db.RelatoriosRas.FindAsync(id);
            if (relatorioRaModels == null)
            {
                return HttpNotFound();
            }
            return View(relatorioRaModels);
        }

        // GET: RelatoriosRas/Create
        public ActionResult Create()
        {
            ViewBag.TagID = new SelectList(db.RelatoriosRas, "TagID", "Tag");
            return View();
        }

        // POST: RelatoriosRas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "RaID,Data,Nivel,Nº,TagID")] RelatorioRaModels relatorioRaModels)
        {
            if (ModelState.IsValid)
            {
                db.RelatoriosRas.Add(relatorioRaModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.TagID = new SelectList(db.RelatoriosRas, "TagID", "Tag", relatorioRaModels.TagID);
            return View(relatorioRaModels);
        }

        // GET: RelatoriosRas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatorioRaModels relatorioRaModels = await db.RelatoriosRas.FindAsync(id);
            if (relatorioRaModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.TagID = new SelectList(db.RelatoriosRas, "TagID", "Tag", relatorioRaModels.TagID);
            return View(relatorioRaModels);
        }

        // POST: RelatoriosRas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "RaID,Data,Nivel,Nº,TagID")] RelatorioRaModels relatorioRaModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatorioRaModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.TagID = new SelectList(db.RelatoriosRas, "TagID", "Tag", relatorioRaModels.TagID);
            return View(relatorioRaModels);
        }

        // GET: RelatoriosRas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatorioRaModels relatorioRaModels = await db.RelatoriosRas.FindAsync(id);
            if (relatorioRaModels == null)
            {
                return HttpNotFound();
            }
            return View(relatorioRaModels);
        }

        // POST: RelatoriosRas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RelatorioRaModels relatorioRaModels = await db.RelatoriosRas.FindAsync(id);
            db.RelatoriosRas.Remove(relatorioRaModels);
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
