﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication_TW.Domain.Enums;

namespace WebApplication_TW.Domain.Entities.User
{
    public class UserMinimal
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
        public string LastIp { get; set; }
        public URole level { get; set; }
    }
}
