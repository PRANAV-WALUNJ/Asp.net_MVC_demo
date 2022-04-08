using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_crud.Models;

namespace MVC_crud.Controllers
{
    public class UserloginsController : Controller
    {
        private EFDemoDbEntities db = new EFDemoDbEntities();

        // GET: Userlogins
        public ActionResult Index()
        {
            return View(db.Userlogins.ToList());
        }

        // GET: Userlogins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userlogin userlogin = db.Userlogins.Find(id);
            if (userlogin == null)
            {
                return HttpNotFound();
            }
            return View(userlogin);
        }

        // GET: Userlogins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Userlogins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Username,FirstName,LastName,MobileNumber,Email,Gender,Password")] Userlogin userlogin)
        {
            if (ModelState.IsValid)
            {
                db.Userlogins.Add(userlogin);
                db.SaveChanges();
                return RedirectToAction("thanks");
            }

            return View(userlogin);
        }

        // GET: Userlogins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userlogin userlogin = db.Userlogins.Find(id);
            if (userlogin == null)
            {
                return HttpNotFound();
            }
            return View(userlogin);
        }

        // POST: Userlogins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Username,FirstName,LastName,MobileNumber,Email,Gender,Password")] Userlogin userlogin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userlogin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userlogin);
        }

        public ActionResult thanks()
        {
            return View();
        }
        // GET: Userlogins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Userlogin userlogin = db.Userlogins.Find(id);
            if (userlogin == null)
            {
                return HttpNotFound();
            }
            return View(userlogin);
        }

        // POST: Userlogins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Userlogin userlogin = db.Userlogins.Find(id);
            db.Userlogins.Remove(userlogin);
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

        public ActionResult Login()
        {
            return View();
        }
    }
}
