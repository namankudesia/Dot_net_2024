using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Namanques2.Models
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(int id);
        Movie GetMovie(int id);
        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Movie> GetMoviesByYear(int year);
    }
}
