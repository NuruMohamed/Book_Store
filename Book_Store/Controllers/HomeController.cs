using Book_Store.DBContext;
using Book_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace Book_Store.Controllers
{
    public class HomeController : Controller
    {
        public DBContextClass db = new DBContextClass();
        public ActionResult Index()
        {
            /*List<Users> user = new List<Users>();
            using (DBContextClass DBmodel = new DBContextClass())
            {
                user = DBmodel.Users.ToList<Users>();
            }
            //var u = from uu in db.User select uu;
            var u = db.Users.FirstOrDefault(s => s.id == 1);
            //ViewBag.data = user;
            if(u != null)
            {
                return Content(u.email);

            }
            ViewBag.dat = u;*/
            var popularBooks = db.Books.Take(6).Where(data => true).ToList<Books>();
            var fictionBooks = db.Books.Take(4).Where(data => true).ToList<Books>();

            ViewBag.popularBooks = popularBooks;
            ViewBag.fictionBooks = fictionBooks;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var result = db.Users.Take(3).Where(data => true).ToList<Users>();
            var res = db.Books.Where(data => true).ToList<Books>();
            /*result.Any() to check if result has no value,  if result is a list */
            /*if (result.Any())
            {
                //ModelState.AddModelError("Name", "the name already exist");
                return Content(result.ToString());
            }*/
            ViewBag.dat = result;
            return View(result);
        }

        [Route("search")]
        public ActionResult Search(string term, int? page)
        {
            var searchedBooks = db.Books.Where(book => book.title.Contains(term)).ToList<Books>();
            ViewBag.searchResult = searchedBooks;
            ViewBag.searchTerm = term;
            return View();
        }
    }
}