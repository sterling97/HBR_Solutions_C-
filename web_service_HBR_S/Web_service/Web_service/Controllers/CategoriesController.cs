using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Web_service;

namespace Web_service.Controllers
{
    public class CategoriesController : Controller
    {
        private HBREntities db = new HBREntities();

        // GET: Categories
        public ActionResult Index()
        {

            List<CATEGORY> result = db.Database.SqlQuery<CATEGORY>("sp_category_get_list").ToList();
            return View(result);
        }

        // GET: Categories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORY cATEGORY = db.CATEGORies.Find(id);
            if (cATEGORY == null)
            {
                return HttpNotFound();
            }
            return View(cATEGORY);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NAME")] CATEGORY cATEGORY)
        {
            if (ModelState.IsValid)
            {

                var parameters = new[]
                {
                    new SqlParameter("@0", cATEGORY.NAME)
                };

                var result = db.Database.SqlQuery<CATEGORY>("sp_cateogory_create @NAME=@0", parameters).ToListAsync();

                return Json(result.Result);

            }

            return View(cATEGORY);
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORY cATEGORY = db.CATEGORies.Find(id);
            if (cATEGORY == null)
            {
                return HttpNotFound();
            }
            return View(cATEGORY);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NAME")] CATEGORY cATEGORY)
        {
            if (ModelState.IsValid)
            {

                var parameters = new[]
                {
                    new SqlParameter("@0", cATEGORY.ID),
                    new SqlParameter("@1", cATEGORY.NAME),
                };

                var result = db.Database.SqlQuery<int>("sp_cateogory_edit @ID=@0,@NAME=@1 ", parameters);

                return Json(result);
            }
            return View(cATEGORY);
        }

        // POST: Products/Search/string
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(string keyword)
        {
            var parameters = new[]
            {
                new SqlParameter("@0", keyword)
            };

            List<CATEGORY> result = db.Database.SqlQuery<CATEGORY>("sp_category_search @KEYWORD=@0", parameters).ToList();

            return Json(result);
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CATEGORY cATEGORY = db.CATEGORies.Find(id);
            if (cATEGORY == null)
            {
                return HttpNotFound();
            }
            return View(cATEGORY);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
           
            var parameters = new[]
               {
                    new SqlParameter("@0", id)
                };

            var result = db.Database.SqlQuery<int>("sp_category_delete @ID=@0", parameters);

            return Json(result);
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
