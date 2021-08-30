using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmTavsiye.Models.DbModels;

namespace FilmTavsiye.Business.Movies
{
    public interface IMovieManager
    {
        public List<Movie> GetAll();
        public Movie Get();
    }
}
