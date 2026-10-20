using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watchlist_ClassLibrary.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string PasswordHash { get; set; } = "";
        public string Role { get; set; } = "User";
        public DateTime CreatedAt { get; set; }
        public bool IsBlocked { get; set; }
    }
}
