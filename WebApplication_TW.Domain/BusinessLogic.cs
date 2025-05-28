using WebApplication_TW.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication_TW.BusinessLogic;

namespace FinalWebTODO.BusinessLogic
{
    public class BussinessLogic
    {
        public ISession GetSessionBl()
        {
            return new SessionBl();
        }
        public ISessionAdmin GetAdminSessionBL()
        {
            return new AdminSessionBL();
        }
    }
}
