using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchlist_ClassLibrary.DTOS
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Role { get; set; } = "User";
        public bool IsBlocked { get; set; }
    }
}
