using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoSolution.Models;

namespace ToDoSolution.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            this.ViewData.Add("foo", "test foo");

            return View(new HomeViewModel
            {
                Name = "My Firts MVC App",
                WelcomeMessage = "Welcome to my first MVC APp ever"
            });
        }
    }
}