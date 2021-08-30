using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmTavsiye.Models;
using FilmTavsiye.Models.DbModels;

namespace FilmTavsiye.Business.Movies
{
    public class MovieManager : IMovieManager
    {
        public List<Movie> GetAll()
        {
            var m = new Models.DbModels.Movie();

            using (Context c = new Context())
            {
                m = c.Movies.FirstOrDefault();
            }

            return new List<Movie>();
        }

        public Movie Get()
        {
            return new Movie();
        }
    }
}
