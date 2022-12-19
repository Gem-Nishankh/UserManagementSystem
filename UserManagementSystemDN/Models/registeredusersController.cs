using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserManagementSystemDN.Models;

namespace UserManagementSystemDN.Models
{
    public class registeredusersController : Controller
    {
        // GET: registeredusers
        public ActionResult Index()
        {
            using (training_dbEntities1 dbmodel = new training_dbEntities1())
            {
                return View(dbmodel.users_nishankh.ToList());
            }
        }

        // GET: registeredusers/Details/5
        public ActionResult Details(int id)
        {
            using (training_dbEntities1 dbModel = new training_dbEntities1())
            {
                return View(dbModel.users_nishankh.Where(x => x.UserID == id).FirstOrDefault());
            }
        }

        // GET: registeredusers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: registeredusers/Create
        [HttpPost]
        public ActionResult Create(users_nishankh customer)
        {
            try
            {
                using (training_dbEntities1 dbModel = new training_dbEntities1())
                {
                    dbModel.users_nishankh.Add(customer);
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Insertion/Edit/5
        public ActionResult Edit(int id)
        {
            using (training_dbEntities1 dbModel = new training_dbEntities1())
            {
                return View(dbModel.users_nishankh.Where(x => x.UserID == id).FirstOrDefault());
            }



        }



        // POST: Insertion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, users_nishankh customer)
        {
            try
            {
                using (training_dbEntities1 dbModel = new training_dbEntities1())
                {
                    dbModel.Entry(customer).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                // TODO: Add update logic here



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Insertion/Delete/5
        public ActionResult Delete(int id)
        {
            using (training_dbEntities1 dbModel = new training_dbEntities1())
            {
                return View(dbModel.users_nishankh.Where(x => x.UserID == id).FirstOrDefault());
            }
        }



        // POST: Insertion/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (training_dbEntities1 dbModel = new training_dbEntities1())
                {
                    users_nishankh customer = dbModel.users_nishankh.Where(x => x.UserID == id).FirstOrDefault();
                    dbModel.users_nishankh.Remove(customer);
                    dbModel.SaveChanges();
                }
                // TODO: Add delete logic here



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
