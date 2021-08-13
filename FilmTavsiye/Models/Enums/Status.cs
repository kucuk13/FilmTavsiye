using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmTavsiye.Models.Enums
{
    public enum Status
    {
        Active = 1,
        Passive = 2,
        Deleted = 3,
        PendingEditorApproval = 4,
        PendingAdminApproval = 5,
        Denied = 6
    }
}
