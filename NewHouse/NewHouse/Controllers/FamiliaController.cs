using NewHouse.BusinessTier.Services;
using NewHouse.DAL;
using NewHouse.Models;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace NewHouse.Controllers
{
    public class FamiliaController : Controller
    {
        private NewHouseContext db = new NewHouseContext();

        // GET: Familia
        public ActionResult Index()
        {
            return View(db.Familia.ToList());
        }

        // GET: Familia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Familia Familia = db.Familia.Find(id);
            if (Familia == null)
            {
                return HttpNotFound();
            }

            return View(Familia);
        }

        // GET: Familia/Create
        public ActionResult Create()
        {
            ViewBag.Codigo = FamiliaService.GerarCodigo();

            return View();
        }

        // GET: Familia/List
        public ActionResult List()
        {
            ViewBag.Familias = FamiliaService.SomarPontos(db.Familia.ToList());

            return View();
        }

        // POST: Familia/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,Renda,Contato,Endereco,NaoDependentes,Dependentes")] Familia familia)
        {
            if (ModelState.IsValid)
            {

                familia.Renda = FamiliaService.RendaFamiliar(familia.NaoDependentes);

                db.Familia.Add(familia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(familia);
        }

        // GET: Familia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Familia Familia = db.Familia.Find(id);
            if (Familia == null)
            {
                return HttpNotFound();
            }
            return View(Familia);
        }

        // POST: Familia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Renda")] Familia Familia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Familia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Familia);
        }

        // GET: Familia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Familia Familia = db.Familia.Find(id);
            if (Familia == null)
            {
                return HttpNotFound();
            }
            return View(Familia);
        }

        // POST: Familia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Familia familia = db.Familia.Find(id);
            db.Familia.Remove(familia);
            db.SaveChanges();
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
