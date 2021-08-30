using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmTavsiye.Models.DbModels;
using FilmTavsiye.Models.Dtos;

namespace FilmTavsiye.Business
{
    public interface ILoginManager
    {
        public Task<bool> Login(LoginDto model);
    }
}
