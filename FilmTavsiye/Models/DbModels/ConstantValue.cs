using FilmTavsiye.Models.Infrastructures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.DbModels
{
    public class ConstantValue : BaseEntity
    {
        public string Name { get; set; }
        public int ConstantId { get; set; }

        [ForeignKey("ConstantId")]
        public virtual Constant Constant { get; set; }
    }
}
