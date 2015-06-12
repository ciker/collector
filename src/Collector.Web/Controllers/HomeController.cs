using Collector.BusinessLogic;
using Collector.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Collector.Web.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        private readonly UserBusinessLogic userLogic;

        public HomeController(UserBusinessLogic userLogic)
        {
            this.userLogic = userLogic;
        }
        public ActionResult Index()
        {
            T_User user = new T_User()
            {
                AddDate = DateTime.Now,
                Email = "",
                LastLogin = DateTime.Now,
                Password = "",
                Photo = "",
                Type = 0,
                UserName = "bin"
            };
            int uid=userLogic.Insert(user);
            return View();
        }
    }
}