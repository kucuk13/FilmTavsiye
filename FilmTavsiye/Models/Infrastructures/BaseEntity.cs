using FilmTavsiye.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.Infrastructures
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedMemberId { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? UpdatedMemberId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public int? DeletedMemberId { get; set; }
        public int? DemandId { get; set; }
        public Status Status { get; set; }
    }
}
