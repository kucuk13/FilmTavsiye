using FilmTavsiye.Models.Infrastructures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "{0} can not be empty.")]
        [Display(Name="User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} can not be empty.")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
