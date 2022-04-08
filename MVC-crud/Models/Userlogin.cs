using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit.Sdk;

namespace MVC_crud.Models
{
    public class Userlogin
    {
        public int ID { get; set; } 

        [Required]
        [Display(Name = "Username")]
        [System.Web.Mvc.Remote("IsUserNameAvailable", "Account", ErrorMessage = "Username Already Exist")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [System.Web.Mvc.Remote("IsMobileAvailable", "Account", ErrorMessage = "Mobile Number Already Exist")]
       
        [Display(Name = "Mobile Number")]
        public double MobileNumber { get; set; }

        [Required]
        [System.Web.Mvc.Remote("IsEmailAvailable", "Account", ErrorMessage = "Email Id Already Exist")]
        [Display(Name = "Email ID")]
        [RegularExpression(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}