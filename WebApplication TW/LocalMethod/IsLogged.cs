﻿using WebApplication_TW.Domain.Enums;
using WebApplication_TW.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_TW.LocalMethod
{
    public class IsLogged
    {
        public static bool isLogged()
        {
            var user = HttpContext.Current.GetMySessionObject();

            if (user != null)
            {
                return true;
            }
            {
                return false;
            }
        }
    }
}