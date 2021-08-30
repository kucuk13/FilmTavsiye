using FilmTavsiye.Models.Infrastructures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.DbModels
{
    public class MemberRole : BaseEntity
    {
        public int MemberId { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }
        [ForeignKey("RoleId")]
        public virtual ConstantValue Role { get; set; }
    }
}
