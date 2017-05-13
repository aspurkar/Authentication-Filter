using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthFilter.Models
{
    public class LoginModel
    {
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Username { get; set; }
    }
}