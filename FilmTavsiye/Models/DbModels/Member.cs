using FilmTavsiye.Models.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.DbModels
{
    public class Member : BaseEntityForMember
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
