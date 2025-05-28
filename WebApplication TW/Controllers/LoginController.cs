using WebApplication_TW.BusinessLogic;
using WebApplication_TW.BusinessLogic.Interfaces;
using WebApplication_TW.Domain.Entities.User;
using WebApplication_TW.Models;
using System;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using System.Web.Security;
using FinalWebTODO.BusinessLogic;


namespace WebApplication_TW.Controllers
{
    public class LoginController : Controller
    {

        private readonly ISession _session;
        public LoginController()
        {
            var bl = new BussinessLogic();
            _session = bl.GetSessionBl();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserLogin login)
        {
            Session.Abandon();
            FormsAuthentication.SignOut();

            HttpContext.Session["UserProfile"] = login;
            if (Response.Cookies["X-KEY"] != null)
            {
                var cookie = new HttpCookie("X-KEY")
                {
                    Expires = DateTime.Now.AddDays(-1),
                    HttpOnly = true
                };
                Response.Cookies.Add(cookie);
            }


            if (ModelState.IsValid)
            {
                var data = Mapper.Map<ULoginDate>(login);
                
                data.LoginIp = Request.UserHostAddress;
                data.LoginDateTime = DateTime.Now;

                var userLogin = _session.UserLogin(data);

                if (userLogin.Status)
                {
                    HttpCookie cookie = _session.GenCookie(login.Credential);
                    ControllerContext.HttpContext.Response.Cookies.Add(cookie);

                    return RedirectToAction("Login", "Home");
                }
                else
                {
                    ModelState.AddModelError("", userLogin.StatusMsg);
                    return View();
                }
                  
            }
            return View();
        }
    }
}