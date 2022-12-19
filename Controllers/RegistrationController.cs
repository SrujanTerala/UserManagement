using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Web.Razor.Generator;
using UserManagementSys.Models;
using System.Data.Entity.Infrastructure;

namespace UserManagementSys.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration


        public ActionResult signup()
        {
            ViewBag.Message = "Registration";

            return View();
        }



        public ActionResult fgpass()
        {
            ViewBag.Message = "fgpass";

            return View();
        }
        public ActionResult InsertUserDetails()
        {
            using (training_dbEntities1 dbmodel = new training_dbEntities1())
            {
                return View(dbmodel.userdetailsses.ToList());
            }
               

        }


    }
}