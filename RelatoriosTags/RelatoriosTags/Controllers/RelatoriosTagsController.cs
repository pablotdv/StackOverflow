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
using RelatoriosTags.ViewModels;

namespace RelatoriosTags.Controllers
{
    public class RelatoriosTagsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: RelatoriosTags
        public async Task<ActionResult> Index(RelatoriosTagsViewModel model)
        {    
            if (model == null)
            {
                model = new RelatoriosTagsViewModel();
            }
                
            var query = db.RelatoriosTags.AsQueryable();
                        
            if (!String.IsNullOrWhiteSpace(model.Tag))
            {
                query = query.Where(a => a.Tag.Equals(model.Tag));
            }

            model.RelatoriosTags = await query.ToListAsync();

            return View(model);
        }

        // GET: RelatoriosTags/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatorioTagModels relatorioTagModels = await db.RelatoriosTags.FindAsync(id);
            if (relatorioTagModels == null)
            {
                return HttpNotFound();
            }
            return View(relatorioTagModels);
        }

        // GET: RelatoriosTags/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatoriosTags/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TagID,Tag,Vedacao,Fluido,Criticidade,Mtbf")] RelatorioTagModels relatorioTagModels)
        {
            if (ModelState.IsValid)
            {
                db.RelatoriosTags.Add(relatorioTagModels);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(relatorioTagModels);
        }

        // GET: RelatoriosTags/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatorioTagModels relatorioTagModels = await db.RelatoriosTags.FindAsync(id);
            if (relatorioTagModels == null)
            {
                return HttpNotFound();
            }
            return View(relatorioTagModels);
        }

        // POST: RelatoriosTags/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "TagID,Tag,Vedacao,Fluido,Criticidade,Mtbf")] RelatorioTagModels relatorioTagModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatorioTagModels).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(relatorioTagModels);
        }

        // GET: RelatoriosTags/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RelatorioTagModels relatorioTagModels = await db.RelatoriosTags.FindAsync(id);
            if (relatorioTagModels == null)
            {
                return HttpNotFound();
            }
            return View(relatorioTagModels);
        }

        // POST: RelatoriosTags/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RelatorioTagModels relatorioTagModels = await db.RelatoriosTags.FindAsync(id);
            db.RelatoriosTags.Remove(relatorioTagModels);
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
