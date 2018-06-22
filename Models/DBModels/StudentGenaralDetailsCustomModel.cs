using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Models.DBModels
{
    public class StudetGenaralDetailsCustomModel
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

    }
}