using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Models.DBModels
{
    public class StudentFamilyDetailsViewModel
    {
        //properties
        #region
            [Required]
            [Display(Name ="Name")]
        public string FatherName { get; set; }
        [Required]
        [Display(Name = "Occupation")]
        public string FatherOccupation { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string FatherDesignation { get; set; }
        [Required]
        [Display(Name = "Qualification")]
        public string FatherQualification { get; set; }
        [Required]
        [Display(Name = "Income")]
        public string FatherIncomeMonthly { get; set; }
        [Required]
        [Display(Name = "Office Address")]
        public string  FatherOfficeAddress { get; set; }
        [Required]
        [Display(Name = "Contact no")]
        public string FatherContactNo { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string FatherEmail { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string MotherName { get; set; }
        [Required]
        [Display(Name = "Occupation")]
        public string MotherOccupation { get; set; }
        [Required]
        [Display(Name = "Designaiton")]
        public string MotherDesignation { get; set; }
        [Required]
        [Display(Name = "Qualification")]
        public string MotherQualification { get; set; }
        [Required]
        [Display(Name = "Income")]
        public string MotherIncomeMonthly { get; set; }

        [Required]
        [Display(Name = "Office Address")]
        public string MotherOfficeAddress { get; set; }
        [Required]
        [Display(Name = "Contact No.")]
        public string MotherContactNo { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string MotherEmail { get; set; }
        [Required]
        [Display(Name = "Family ")]
        public string FamilyIncomeMonthly { get; set; }
        [Required]
        [Display(Name = "Guardian's Name")]
        public string  FamilyGuardianName { get; set; }
        [Required]
        [Display(Name = "Relationship")]
        public string  FamilyRelaltionship { get; set; }
        [Required]
        [Display(Name = "Contact No.")]
        public string FamilyContatNo { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string FamilEmail { get; set; }

        #endregion

        //methods
        public void AddFamilyDetails(StudentFamilyDetailsViewModel newData)
        {
            StudentFamilyDetail dbInstance = new StudentFamilyDetail();
            using (CISERPEntities db = new CISERPEntities())
            {
                dbInstance.FatherName = newData.FatherName;
                dbInstance.FatherContactNo = newData.FatherContactNo;
                dbInstance.FatherDesignation = newData.FatherDesignation;
                dbInstance.FatherEmail = newData.FatherEmail;
                dbInstance.FatherIncomeMonthly = newData.FatherIncomeMonthly;
                dbInstance.FatherOccupation = newData.FatherOccupation;
                dbInstance.FatherOfficeAddress = newData.FatherOfficeAddress;
                dbInstance.FatherQualification = newData.FatherQualification;
                dbInstance.MotherContactNo = newData.MotherContactNo;
                dbInstance.MotherDesignation = newData.MotherDesignation;
                dbInstance.MotherIncomeMonthly = newData.MotherIncomeMonthly;
                dbInstance.MotherName = newData.MotherName;
                dbInstance.MotherOccupation = newData.MotherOccupation;
                dbInstance.MotherOfficeAddress = newData.MotherOfficeAddress;
                dbInstance.MotherQualification = newData.MotherQualification;
                dbInstance.FamilyEmail = newData.FamilEmail;
                dbInstance.FamilyGuardianName = newData.FamilyGuardianName;
                dbInstance.FamilyIncomeMonthly = newData.FamilyIncomeMonthly;
                dbInstance.FamilyRelationship = newData.FamilyRelaltionship;
                dbInstance.FatherContactNo = newData.FatherContactNo;

                db.StudentFamilyDetails.Add(dbInstance);
                db.SaveChanges();
            }
        }
    }
}