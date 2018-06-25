using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Models.DBModels
{
    public class PreviousSchoolDetailsViewModels
    {
        #region
        [Required]
        [Display(Name ="Country")]
        public int CountryId { get; set; }
        [Required]
        [Display(Name = "State")]
        public int StateId { get; set; }
        [Required]
        [Display(Name = "City")]
        public int CityId { get; set; }
        [Required]
        public string Medium { get; set; }
        public string  Class{ get; set; }
        [Required]
        [Display(Name = "From")]
        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }
        [Required]
        [Display(Name = "To")]
        [DataType(DataType.Date)]
        public DateTime ToDate { get; set; }
        public string Marks { get; set; }
        public string Percentage { get; set; }
        [Required]
        [Display(Name = "School/ College Name")]
        public string SchoolName { get; set; }
        [Required]
        [Display(Name = "School/ College Address")]
        public string SchooolAddress { get; set; }
        [Required]
        [Display(Name ="Board/ Univesity")]
        public string Board { get; set; }
        #endregion
        public void SaveData()
        {
            using (CISERPEntities db = new CISERPEntities())
            {
                StudentPreviousSchool newData = new StudentPreviousSchool();
                newData.Board = this.Board;
                newData.CityId = this.CityId;
                newData.Class = this.Class;
                newData.CountryId = this.CountryId;
                newData.FromDate = this.FromDate;
                newData.Marks = this.Marks;
                newData.Medium = this.Medium;
                newData.Percentage = this.Percentage;
                newData.Schooladdress = this.SchooolAddress;
                newData.SchoolName = this.SchoolName;
                newData.ToDate = this.ToDate;
                newData.StateId = this.StateId;

                db.StudentPreviousSchools.Add(newData);
                db.SaveChanges();
            }
        }
    }
}