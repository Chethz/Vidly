using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movie
        public ViewResult Index()
        {
            if (User.IsInRole(RoleNames.CanManageMovies))
                return View("List");
            return View("ReadOnlyList");
        }

        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(mov => mov.Genre).SingleOrDefault(m => m.Id == Id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        [Authorize(Roles = RoleNames.CanManageMovies)]
        public ActionResult New()
        {
            var genre = _context.Genres.ToList();
            var viewModel = new NewMovieViewModel
            {
                //Movie = new Movie(),
                Genres = genre
            };
            return View("MovieForm",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleNames.CanManageMovies)]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewMovieViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var moviesInDb = _context.Movies.Single(c => c.Id == movie.Id);

                moviesInDb.Name = movie.Name;
                moviesInDb.ReleaseDate = movie.ReleaseDate;
                moviesInDb.GenreId = movie.GenreId;
                moviesInDb.NumberInStock = movie.NumberInStock;
            }
           // _context.Movies.Add(movie);
            _context.SaveChanges();

            return RedirectToAction("Index", "Movie");
        }

        [Authorize(Roles = RoleNames.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }
            
            var viewModel = new NewMovieViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }
    }
}