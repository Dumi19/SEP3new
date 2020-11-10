using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor.Models;

namespace Blazor.Data
{
    public interface IAddUserService
    {
        Task<List<User>> GetUserAsync();
        
    }
}