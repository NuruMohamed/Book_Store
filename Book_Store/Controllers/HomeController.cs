using Book_Store.DBContext;
using Book_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Book_Store.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            List<User> user = new List<User>();
            using (DBContextClass DBmodel = new DBContextClass())
            {
                user = DBmodel.User.ToList<User>();
            }
            ViewBag.data = user;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}