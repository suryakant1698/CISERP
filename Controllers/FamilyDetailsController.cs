using CMS.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class FamilyDetailsController : Controller
    {
        // GET: FamilyDetails
        [HttpGet]
        [ActionName("AddFamilyDetails")]
        public ActionResult AddFamilyDetails_Get()
        {
            PopulateViewBags();
            return View();
        }

        [HttpPost]
        [ActionName ("AddFamilyDetails")]
        public ActionResult AddFamilyDetails_Post()
        {
            PopulateViewBags();
            return View();
        }
        public void PopulateViewBags()
        {
            Relationship re = new Relationship();
            Occupation oc = new Occupation();
            ViewBag.RelationshipList =new SelectList(re.GetRelationshipList(),"Name","Name");
            ViewBag.OccupationList =new SelectList(oc.GetOccupationList(),"Name","Name");
        }
    }
}