using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using MyCV.Models.EntityFramework;
using MyCV.Models.Class;

namespace MyCV.Controllers
{
    public class DefaultController : Controller
    {
        CVDBEntities1 db = new CVDBEntities1();
        // GET: Default
        public ActionResult Index()
        {
            
            MyCVClass cvClass = new MyCVClass();

            cvClass.dbMe = db.tblMes.ToList();
            cvClass.dbSite = db.tblSites.ToList();
            cvClass.dbSkill = db.tblSkills.ToList();


            return View(cvClass);
            
        }
    }
}