using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new List<Movie>
            {
                new Movie {Name = "Shrek!"},
                new Movie {Name = "Wall=e"}
            };
            var customers = new List<Customer>
            {
                new Customer {Name = "customer 1"},
                new Customer {Name = "customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movie,
                Customers = customers
            };

            //ViewData["Movie"] = movie;

            return View(viewModel);
            //return Content("hello world!");
            //return HttpNotFound();
            //return  new EmptyResult();
            //return RedirectToAction("index", "Home",new {page=1,sortby="name"});
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}

        //movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "name";

        //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year}/{month:range(1,12)}")]
        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //    return Content(year+"/"+month);
        //}

        ////mine
        //public ActionResult Index()
        //{
        //    var viewmodel = GetMovies(FillList());

        //    return View(viewmodel);
        //}

        //private MovieViewModel GetMovies(List<Movie> movieList)
        //{
        //    return new MovieViewModel
        //    {
        //        Movies = movieList
        //    };
        //}

        //private List<Movie> FillList()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie {Name = "Shrek!",Id = 1},
        //        new Movie {Name = "Wall=e",Id = 2}
        //    };
        //}

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //mosh
        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        //private IEnumerable<Movie> GetMovies()
        //{
        //    return new List<Movie>
        //    {
        //        new Movie {Name = "Shrek!",Id = 1},
        //        new Movie {Name = "Wall-e",Id = 2}
        //    };
        //}
    }
}