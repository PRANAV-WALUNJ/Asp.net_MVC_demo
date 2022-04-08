using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_crud.Models
{
    public class Login
    {
        public class LoginVM
        {
            [Required]

            public string Username { get; set; }

            
            public string Password { get; set; }
        }
    }
}