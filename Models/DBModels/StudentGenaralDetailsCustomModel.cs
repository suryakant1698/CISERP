using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Models.DBModels
{
    public class StudentGenaralDetailsCustomModel
    {
        //properties
        #region
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public System.DateTime DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string Religion { get; set; }
        [Required]
        public string Cast { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string BloodGroup { get; set; }

        public string HouseName { get; set; }
        [Required]
        [Display(Name ="Address")]
        public string StLocalAddress { get; set; }
        [Required]
        [Display(Name ="State")]
        public Nullable<int> StLocalStateId { get; set; }
        [Required]
        [Display(Name ="City")]
        public Nullable<int> StLocalCityId { get; set; }
        [Required]
        [Display(Name ="Zip")]
        public string StLocalZip { get; set; }
        [Required]
        [Display(Name ="Address")]
        public string StPerAddress { get; set; }
        [Required]
        [Display(Name ="State")]
        public Nullable<int> StPerStateId { get; set; }
        [Required]
        [Display(Name ="City")]
        public Nullable<int> StPerCityId { get; set; }
        [Required]
        [Display(Name ="Zip")]
        public string StPerZip { get; set; }
        #endregion
        //methods
        public void SaveNewStudent(StudentGenaralDetailsCustomModel newData)
        {
            using (CISERPEntities db = new CISERPEntities())
            {
                StudentGenaralDetail newStudent = new StudentGenaralDetail();
                newStudent.FirstName = newData.FirstName;
                newStudent.LastName = newData.LastName;
                newStudent.Gender = newData.Gender;
                newStudent.DOB = newData.DateOfBirth;
                newStudent.BloodGroup = newData.BloodGroup;
                newStudent.Caste = newData.Cast;
                newStudent.Category = newData.Category;
                newStudent.Email = newData.Email;
                newStudent.MiddleName = newData.MiddleName;
                newStudent.MobileNumber = newData.MobileNumber;
                newStudent.Nationality = newData.Nationality;
                newStudent.Religion = newData.Religion;
                newStudent.StLocalAddress = newData.StLocalAddress;
                newStudent.StLocalCityId = newData.StLocalCityId;
                newStudent.StLocalStateId = newData.StLocalStateId;
                newStudent.StLocalZip = newData.StLocalZip;
                newStudent.StPerAddress = newData.StPerAddress;
                newStudent.StPerCityId = newData.StPerCityId;
                newStudent.StPerStateId = newData.StPerStateId;
                newStudent.StPerZip = newData.StPerZip;

                db.StudentGenaralDetails.Add(newStudent);
                db.SaveChanges();
            }
        }
    }
}