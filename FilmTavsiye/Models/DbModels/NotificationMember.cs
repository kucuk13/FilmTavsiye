using FilmTavsiye.Models.Infrastructures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.DbModels
{
    public class NotificationMember : BaseEntity
    {
        public int NotificationId { get; set; }
        public int MemberId { get; set; }
        public bool IsRead { get; set; }

        [ForeignKey("NotificationId")]
        public virtual Notification Notification { get; set; }
        [ForeignKey("MemberId")]
        public virtual Member Member { get; set; }
    }
}
