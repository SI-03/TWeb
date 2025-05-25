using WebApplication_TW.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebApplication_TW;
using System.Configuration;
using System.Web;
using System.Data.Entity;

namespace WebApplication_TW.BusinessLogic.DBModels
{
    class UserContext : DbContext
    {
        public UserContext() :
            base("name=WebApplication_TW")
        {
        }
        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
