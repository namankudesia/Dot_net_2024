using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Namanques2.Models;
using System.Data.Entity;

namespace Namanques2.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviesDbContext _context;

        public MovieRepository(MoviesDbContext context)
        {
            _context = context;
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            _context.Entry(movie).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
        }

        public Movie GetMovie(int id)
        {
            return _context.Movies.Find(id);
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        public IEnumerable<Movie> GetMoviesByYear(int year)
        {
            return _context.Movies.Where(m => m.DateofRelease.Year == year).ToList();
        }
    }
}