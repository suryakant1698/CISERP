using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.Models.DBModels;
using CMS.CustomModels;

namespace CMS.Controllers
{
    public class StudentRegisterController : Controller
    {
        MasterTablesOperations masterReadOperations=new MasterTablesOperations();
        //StudentRegisterController()
        //{
        //    masterReadOperations = new MasterTablesOperations();
        //}
        // GET: StudentReister
        [HttpGet]
        [ActionName("AddGenralDetails")]
        public ActionResult AddGenralDetails_Get()
        {
            PopulateViewbags();
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
        [NonAction]
        public void PopulateViewbags()
        {
            Category cat = new Category();
            BloodGroup bg = new BloodGroup();
            Religion religion = new Religion();
            ViewBag.CountryList = new SelectList(masterReadOperations.getStates(), "Id", "StateName");
            ViewBag.ReligionList = new SelectList(religion.GetAllReligions(), "Name", "Name");
            ViewBag.CategoryList = new SelectList(cat.GetAllcagteories(), "Name", "Name");
            ViewBag.BloodGroupList = new SelectList(bg.GetAllBloodGroups(), "Name", "Name");
        }
        public JsonResult GetCities(int stateId)
        {

        }
    }
}