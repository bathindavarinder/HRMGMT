using Kanrish.Core.Attribute;
using Kanrisha.Services.Interfaces;
using Kanrisha.Services.Respository;
using KanrishaEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kanrisha.Controllers
{
    public class HomeController : Controller
    {
        IUserRepository userRepository = new UserRepository();

        [CustomAuthorize("Admin","HR")]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            
            return View();
        }

        [CustomAuthorize("Admin", "HR")]
        public ActionResult GetUsers()
        {            
            List<TB_UserProfile> users= userRepository.GetUserList();
            ViewBag.menu = "Worker";
            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
