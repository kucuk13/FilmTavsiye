using FilmTavsiye.Models.Infrastructures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.DbModels
{
    public class Notification : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? TypeId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string Url { get; set; }

        [ForeignKey("TypeId")]
        public virtual ConstantValue Type { get; set; }
    }
}
