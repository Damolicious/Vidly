using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movie = new List<Movie>
            {
                new Movie {Name = "Shrek!", Id = 1 },
                new Movie {Name = "Wall-e", Id = 2}
            };
            
            return View(movie);
        }
    }
}