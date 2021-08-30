using FilmTavsiye.Models.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.DbModels
{
    public class Constant : BaseEntity
    {
        public string Name { get; set; }
    }
}
