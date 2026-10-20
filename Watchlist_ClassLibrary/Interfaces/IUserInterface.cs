using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watchlist_ClassLibrary.DTOS;

namespace Watchlist_ClassLibrary.Interfaces
{
    public interface IUserInterface
    {
        Task<UserDTO> RegisterAsync(SignUpDTO request);
        Task<UserDTO?> LoginAsync(LogInDTO request);
    }
}
