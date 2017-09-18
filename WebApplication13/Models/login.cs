using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication13.Models
{
    public class login
    {
        public int ID { get; set; }
        [Required]
        [EmailAddress]
        public String Email { get; set; }
        [DataType(DataType.Password)]
        public String Password { get; set; }

    }
}