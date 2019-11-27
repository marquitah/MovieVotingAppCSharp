using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieVotingApp;
using MovieVotingApp.Models;
using MovieVotingApp.Controllers;

namespace MovieVotingApp.Controllers
{
    public class VotingController : Controller
    {
        MovieModel MovieModel = new MovieModel();

        // GET: Success
        //public ActionResult Index()
        //{
        //    using (MovieVotingEntities db = new MovieVotingEntities())
        //        return View();
        //}

        [HttpPost]

        //Method to submit vote into database

        public ActionResult Vote(string Movie_Title)
        {
            if (string.IsNullOrEmpty(Movie_Title))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (MovieVotingEntities db = new MovieVotingEntities())
                {
                    var voting = new Movy();

                    voting.Movie_Title = Movie_Title;
                    db.Movies.Add(voting);
                    db.SaveChanges();
                }
                ViewBag.TotalVotes = Movie_Title;
                return View("~/Views/Home/Success.cshtml");
            }
        }
    }

   
}