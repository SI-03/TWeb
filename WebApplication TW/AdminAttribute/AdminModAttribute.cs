using WebApplication_TW.BusinessLogic.Interfaces;
using WebApplication_TW.BusinessLogic;
using WebApplication_TW.Domain.Enums;
using WebApplication_TW.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FinalWebTODO.BusinessLogic;

namespace WebApplication_TW.AdminAttribute
{
    public class AdminModAttributes : ActionFilterAttribute
    {
        private readonly ISession _sessionBussinesLogic;

        public AdminModAttributes()
        {
            var bussinesLogic = new BussinessLogic();
            _sessionBussinesLogic = bussinesLogic.GetSessionBl();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var apiCookie = HttpContext.Current.Request.Cookies["X-KEY"];
            if (apiCookie != null)
            {
                var profile = _sessionBussinesLogic.GetUserByCookie(apiCookie.Value);
                if (profile == null)
                {
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index" }));
                }

                if (profile.level != URole.Admin)
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new { controller = "Home", action = "Login" }));
                }

                if (profile.level == URole.Admin)
                {
                    HttpContext.Current.SetMySessionObject(profile);
                }
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Login", action = "Index" }));
            }
        }
    }
}