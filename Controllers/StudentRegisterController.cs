using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.Models.DBModels;

namespace CMS.Controllers
{
    public class StudentRegisterController : Controller
    {
        // GET: StudentReister
        [HttpGet]
        [ActionName("AddGenralDetails")]
        public ActionResult AddGenralDetails_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("AddGenralDetails")]
        public ActionResult AddGenralDetails_Post(StudetGenaralDetailsCustomModel inputData)
        { 
            return View();
        }
        public ActionResult Action()
        {
            using (CISERPEntities db = new CISERPEntities())
            {
                
            }
                return View();
        }
    }
}