using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Models.DBModels
{
    public class StudetDetails
    {
        //properties
        #region
            [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string  LastName { get; set; }
        [Required]
        public System.DateTime  DateOfBirth { get; set; }
        [Required]
        public string  Gender { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        [Required]
        public string MyProperty { get; set; }
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
        public int MyProperty { get; set; }
        #endregion
        //methods

    }
}