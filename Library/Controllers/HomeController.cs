using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Data.Models;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            using (var context = new DBLibraryModel())
            {

                var books = context.BOOK.Where(x => x.Title.ToLower().Contains("A".ToLower())).ToList();
                foreach (var book in books)
                {
                    Debug.WriteLine(book.Title);
                }
            }
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}