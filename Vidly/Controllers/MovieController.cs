using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name="Joker"};
        //    var customers = new List<Customer>
        //    {
        //        new Customer() {Name="Customer1"},
        //        new Customer() {Name="Customer2"}
        //    };

        //    var RandomMovie = new RandomMovieViewModel() { Movie = movie, Customers = customers };
        //    return View(RandomMovie);
        //}
        //[Route("movie/edit/{id}/{name}")]
        //public ActionResult edit(int? id, string name)
        //{
        //    return Content("id="+id+ "and name is"+name);
        //}

        public ActionResult Index() 
        {
            var movies = new List<Movie>
            {
                new Movie(){Name="Shrek"},
                new Movie(){Name="Wall-E"}
            };

            var movieList = new MovieListViewModel() { Movies = movies };
            return View(movieList);
        }
    }
}