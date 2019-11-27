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
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (MovieVotingEntities db = new MovieVotingEntities())
            {
                List<Movy> total = (from v in db.Movies where v.Movie_Title != null select v).ToList();
                var totals = new List<Movy>();
                
                foreach (var totalVotes in total)
                {
                    var totaledVotes = new Movy();
                    totaledVotes.Movie_Title = totaledVotes.Movie_Title;
                    totals.Add(totaledVotes);

                    db.Movies.Add(totaledVotes);
                    db.SaveChanges();
                }


                return View(totals);

            }
           
        }
    }
}