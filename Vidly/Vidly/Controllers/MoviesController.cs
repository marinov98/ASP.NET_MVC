using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }




        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!"},
                new Movie { Id = 2, Name = "Ip Man"}
            };
        }



        //EXAMPLE FROM LECTURES
        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]

        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    var customer = new List<Customer>
        //    {
        //        new Customer { Name = "Customer 1" },
        //        new Customer { Name = "Customer 2"}
        //    };

        //    var viewModel = new RandomMovieViewModel
        //    {
        //        Movie = movie,
        //        Customers = customer
        //    };

        //    //passing data to views VERY BAD (casting issues) DO NOT USE
        //    //ViewData["Movie"] = movie;
        //    //ViewBag.Movie = movie;

        //    return View(viewModel);
        //}
    }
}