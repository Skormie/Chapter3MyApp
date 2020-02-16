using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chapter2MyApp.Models;

namespace Chapter2MyApp.Controllers
{
    public class ActionController : Controller
    {
        // GET: Action
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: Action
        public ActionResult Layout()
        {
            return View();
        }
        
        public ActionResult Css()
        {
            return View();
        }

        public ActionResult InputPage(int input = 0)
        {
            string[] pages = new string[]{ "Index", "Layout", "Css", "InputPage" };
            input = input >= 0 && input < pages.Length ? input : 0;
            return View(pages[input]);
        }
        public ActionResult RequestGame()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RequestGame(RequestGameModel title)
        {
            try
            {
                return RedirectToAction("Thanks");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ActionResult Thanks()
        {
            return View();
        }

    }
}