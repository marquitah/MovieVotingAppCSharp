using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieVotingApp.Models;
using MovieVotingApp.Controllers;

namespace MovieVotingApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (MovieVotingEntities db = new MovieVotingEntities())
            return View();
        }


       
    }
}