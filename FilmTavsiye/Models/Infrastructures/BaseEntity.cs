using FilmTavsiye.Models.DbModels;
using FilmTavsiye.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.Infrastructures
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
        public int CreatedMemberId { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int? UpdatedMemberId { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public int? DeletedMemberId { get; set; }
        public Status Status { get; set; } = Status.Active;



        [ForeignKey("CreatedMemberId")]
        public virtual Member CreatedMember { get; set; }
        [ForeignKey("UpdatedMemberId")]
        public virtual Member UpdatedMember { get; set; }
        [ForeignKey("DeletedMemberId")]
        public virtual Member DeletedMember { get; set; }
    }
}
