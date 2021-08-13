using FilmTavsiye.Models.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.DbModels
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public int Year { get; set; }
        public int DurationInMinutes { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
