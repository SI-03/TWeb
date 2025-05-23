using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_TW.Models
{
    public class UserLogin
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public DateTime LoginDateTime { get; set; }
    }
}