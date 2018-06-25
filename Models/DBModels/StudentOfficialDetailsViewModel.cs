using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Models.DBModels
{
    public class StudentOfficialDetailsViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Date Of Admission")]
        public DateTime DateOfAdmission { get; set; }
        [Required]
        [Display(Name ="Enquiry No.")]
        public string EnquiryNo { get; set; }
        [Required]
        [Display(Name = "Admission For Class/Course")]
        public int AdmissionForClassId { get; set; }
        [Required]
        [Display(Name = "S. R. Number")]
        public string SrNo { get; set; }
        [Required]
        [Display(Name = "Section")]
        public int SectionId { get; set; }
        [Required]
        [Display(Name = "Board/University Roll No.")]
        public string BoardRollNumber { get; set; }
        [Required]
        [Display(Name = "Group")]
        public string GroupNa { get; set; }
        [Required]
        [Display(Name = "File No.")]
        public string FileNo { get; set; }
        public string Medium { get; set; }
        public string Reference { get; set; }
        public string Board{ get; set; }
        [Required]
        [Display(Name = "Fee Group")]
        public string FeeGroup { get; set; }
        [Required]
        [Display(Name = "Type Of Admission")]
        public string TypeOfAdmission { get; set; }
        public string House { get; set; }
        [Required]
        [Display(Name = "Hostel Required")]
        public string HostelRequired { get; set; }
        [Required]
        [Display(Name = "Transport Required")]
        public string TransportRequired { get; set; }
        [Required]
        [Display(Name = "Library Facility")]
        public string LibraryFacility { get; set; }
        public string Remark { get; set; }
        public void SaveOfficialDetails()
        {
            
        }
       
    }
}