using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication13.Models
{
    public class forgot
    {
        public int ID { get; set; }
        [Required]
        [EmailAddress]
        public String Email { get; set; }
        [RegularExpression("030[0-9]-[0-9]{7}", ErrorMessage = "Mobile No i.e 030X-XXXXXXX")]
        [Display(Name="Mobile No")]
        public String Mobile_No { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public String New_Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("New_Password")]
        public String Confrim_Password { get; set; }
    }
}