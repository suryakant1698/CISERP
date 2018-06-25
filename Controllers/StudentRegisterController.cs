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
        public ActionResult AddGenralDetails_Post(StudentGenaralDetailsCustomModel inputData)
        {

            inputData.SaveNewStudent(inputData);
            PopulateViewbags();
            return View();
        }
        [HttpGet]
        [ActionName("FamilyDetails")]
        public ActionResult FamilyDetails_Get()
        {
            PopulateViewbags();
            return View();
        }

        [HttpPost]
        [ActionName("FamilyDetails")]
        public ActionResult FamilyDetails_Post(StudentFamilyDetailsViewModel newData)
        {
            newData.AddFamilyDetails(newData);
            PopulateViewbags();
            return View();
        }
        [HttpGet]
        [ActionName("PreviousSchoolDetails")]
        public ActionResult PreviousSchoolDetails_Get()
        {
            PopulateViewbags();
            return View();
        }
        [HttpPost]
        [ActionName("PreviousSchoolDetails")]
        public ActionResult PreviousSchoolDetails(PreviousSchoolDetailsViewModels newData)
        {
            newData.SaveData();
            PopulateViewbags();
            return View();
        }
        [HttpGet]
        [ActionName("OfficialDetail")]
        public ActionResult OfficialDetails_Get()
        {
            PopulateViewBagsForOfficialDetails();
            return View();
        }
        [HttpPost]
        [ActionName("OfficialDetail")]
        public ActionResult OfficialDetials_Post(StudentOfficialDetailsViewModel newData)
        {
            newData.SaveOfficialDetails();
            return View();
        }
        [NonAction]
        public void PopulateViewbags()
        {
            Category cat = new Category();
            BloodGroup bg = new BloodGroup();
            Religion religion = new Religion();
            Relationship re = new Relationship();
            Occupation oc = new Occupation();
            ViewBag.CountryList = new SelectList(masterReadOperations.GetCountries(),"Id","CountryName");
            ViewBag.RelationshipList = new SelectList(re.GetRelationshipList(), "Name", "Name");
            ViewBag.OccupationList = new SelectList(oc.GetOccupationList(), "Name", "Name");
            ViewBag.StateList = new SelectList(masterReadOperations.getStates(), "Id", "StateName");
            ViewBag.ReligionList = new SelectList(religion.GetAllReligions(), "Name", "Name");
            ViewBag.CategoryList = new SelectList(cat.GetAllcagteories(), "Name", "Name");
            ViewBag.BloodGroupList = new SelectList(bg.GetAllBloodGroups(), "Name", "Name");
        }
        [NonAction]
        public void PopulateViewBagsForOfficialDetails()
        {

            Section sectionList = new Section();
            ViewBag.BoardList = new SelectList(masterReadOperations.GetBoards(), "BoardName", "BoardName");
            ViewBag.SectionList = new SelectList(sectionList.GetSections(),"Id","Name");
            ViewBag.ClassList =new SelectList(masterReadOperations.GetClasses(),"Id","ClassName");
        }

        [NonAction]
        public JsonResult GetCities(int stateId)
        {
            var cityList = masterReadOperations.getCitiesByStateId(stateId);
            return Json(cityList,JsonRequestBehavior.AllowGet);
        }
        [NonAction]
        public JsonResult GetStatesByCountry(int countryId)
        {
            var stateList = masterReadOperations.getStates(countryId);
            return Json(stateList, JsonRequestBehavior.AllowGet);
        }

    }
}
