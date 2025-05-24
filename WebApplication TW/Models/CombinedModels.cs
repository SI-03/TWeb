using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_TW.Models
{
    public class CombinedModels
    {
        public List<WebApplication_TW.Domain.Entities.User.TodoDbTable> TodoList { get; set; }
        public WebApplication_TW.Models.TodoData TodoData { get; set; }  
    }

}