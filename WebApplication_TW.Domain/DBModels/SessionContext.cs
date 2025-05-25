using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication_TW.Domain.Entities.User;

namespace WebApplication_TW.BusinessLogic.DBModels
{
    public class SessionContext : DbContext
    {
        public SessionContext() : base("name=WebApplication_TW")
        {
        }
        public virtual DbSet<Session> Sessions { get; set; }
    }
}
