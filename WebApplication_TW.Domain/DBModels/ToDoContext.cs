﻿using WebApplication_TW.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_TW.BusinessLogic.DBModels
{
    class TodoContext : System.Data.Entity.DbContext
    {
        public TodoContext() :
            base("name=WebApplication_TW")
        {
        }
        public virtual System.Data.Entity.DbSet<TodoDbTable> Todos { get; set; }
    }
}
