using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Namanques2.Models;
using Namanques2.Repositories;

namespace Namanques2.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repository;

        public MovieController()
        {
            _repository = new MovieRepository(new MoviesDbContext());
        }

        public ActionResult Index()
        {
            var movies = _repository.GetAllMovies();
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _repository.AddMovie();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            var movie = _repository.GetMovie(id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _repository.UpdateMovie(movie);
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        public ActionResult Delete(int id)
        {
            var movie = _repository.GetMovie(id);
            if (movie == null)
            {
                return HttpNotFound();
            }

            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            _repository.DeleteMovie(id);
            return RedirectToAction("Index");
        }

        public ActionResult MoviesByYear(int year)
        {
            var movies = _repository.GetMoviesByYear(year);
            return View(movies);
        }
    }
}