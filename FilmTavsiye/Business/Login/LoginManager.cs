using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmTavsiye.Models;
using FilmTavsiye.Models.DbModels;
using FilmTavsiye.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace FilmTavsiye.Business
{
    public class LoginManager : ILoginManager
    {
        public async Task<bool> Login(LoginDto model)
        {
            var m = new Models.DbModels.Movie();

            using (Context c = new Context())
            {
                var member = c.Members.Where(x => x.Name == model.UserName);

                if (member != null)
                {
                    var memberFirst = await member.FirstOrDefaultAsync();

                    if (memberFirst.Password == model.Password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
