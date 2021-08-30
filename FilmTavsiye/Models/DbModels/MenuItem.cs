using FilmTavsiye.Models.Infrastructures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.DbModels
{
    public class MenuItem : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int TypeId { get; set; }

        [ForeignKey("TypeId")]
        public virtual ConstantValue Type { get; set; }
    }
}
