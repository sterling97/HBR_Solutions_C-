using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_service;

namespace Web_service.Controllers
{
    public class ProductsController : Controller
    {
        private HBREntities db = new HBREntities();

        // GET: Products
        public ActionResult Index()
        {
            List<PRODUCT> result = db.Database.SqlQuery<PRODUCT>("sp_product_get_list").ToList();
            return View(result);
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT pRODUCT = db.PRODUCTs.Find(id);
            if (pRODUCT == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.ID_CATEGORY = new SelectList(db.CATEGORies, "ID", "NAME");
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NAME,DESCRIPTION,URL_IMG,ID_CATEGORY,ENABLED,CREATED")] PRODUCT pRODUCT)
        {
            if (ModelState.IsValid)
            {

                var parameters = new[]
                {
                    new SqlParameter("@0", pRODUCT.NAME),
                    new SqlParameter("@1", pRODUCT.DESCRIPTION),
                    new SqlParameter("@2", pRODUCT.ID_CATEGORY),
                    new SqlParameter("@3", pRODUCT.URL_IMG)
                };

                var result = db.Database.SqlQuery<int>("sp_product_create @NAME=@0,@DESCRIPTION=@1,@ID_CATEGORY=@2,@URL_IMG=@3", parameters);

                return Json(result);
            }

            ViewBag.ID_CATEGORY = new SelectList(db.CATEGORies, "ID", "NAME", pRODUCT.ID_CATEGORY);
            return View(pRODUCT);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT pRODUCT = db.PRODUCTs.Find(id);
            if (pRODUCT == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CATEGORY = new SelectList(db.CATEGORies, "ID", "NAME", pRODUCT.ID_CATEGORY);
            return View(pRODUCT);
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NAME,DESCRIPTION,URL_IMG,ID_CATEGORY,ENABLED,CREATED")] PRODUCT pRODUCT)
        {
            if (ModelState.IsValid)
            {
                var parameters = new[]
                 {
                    new SqlParameter("@0", pRODUCT.ID),
                    new SqlParameter("@1", pRODUCT.NAME),
                    new SqlParameter("@2", pRODUCT.DESCRIPTION),
                    new SqlParameter("@3", pRODUCT.ID_CATEGORY),
                    new SqlParameter("@4", pRODUCT.URL_IMG)
                };

                var result = db.Database.SqlQuery<int>("sp_product_edit @ID=@0,@NAME=@1,@DESCRIPTION=@2,@ID_CATEGORY=@3,@URL_IMG=@4", parameters);

                return Json(result);
            }
            ViewBag.ID_CATEGORY = new SelectList(db.CATEGORies, "ID", "NAME", pRODUCT.ID_CATEGORY);
            return View(pRODUCT);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT pRODUCT = db.PRODUCTs.Find(id);
            if (pRODUCT == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT);
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

            List<PRODUCT> result = db.Database.SqlQuery<PRODUCT>("sp_product_search @KEYWORD=@0", parameters).ToList();

            return Json(result);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var parameters = new[]
              {
                    new SqlParameter("@0", id)
                };

            var result = db.Database.SqlQuery<int>("sp_products_delete @ID=@0", parameters);

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
