using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using UserManagementSys.Models;

namespace UserManagementSys.Controllers
{
    public class InsertionController : Controller
    {
        // GET: Insertion
        public ActionResult Index()
        {
            using (training_dbEntities1 dbmodel = new training_dbEntities1())
            {
                return View(dbmodel.userdetailsses.ToList());
            }
            
        }

        // GET: Insertion/Details/5
        public ActionResult Details(int id)
        {
            using (training_dbEntities1 dbModel = new training_dbEntities1())
            {
                return View(dbModel.userdetailsses.Where(x => x.userid == id).FirstOrDefault()); 
            }
            
        }

        // GET: Insertion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insertion/Create
        [HttpPost]
        public ActionResult Create(userdetailss customer)
        {
            try
            {
                // TODO: Add insert logic here

                using(training_dbEntities1 dbModel=new training_dbEntities1())
                {
                    dbModel.userdetailsses.Add(customer);
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
                return View(dbModel.userdetailsses.Where(x => x.userid == id).FirstOrDefault());
            }
           
        }

        // POST: Insertion/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, userdetailss customer)
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
                return View(dbModel.userdetailsses.Where(x => x.userid == id).FirstOrDefault());
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
                    userdetailss customer= dbModel.userdetailsses.Where(x => x.userid == id).FirstOrDefault();
                    dbModel.userdetailsses.Remove(customer);
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

