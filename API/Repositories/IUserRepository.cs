using API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUserAssignmentAsync();

        Task AddNewUserAsync(User user);

        Task<User> GetUserByIdAsync(int id);

        Task<bool> DeleteUserAsync(int id);

        Task<bool> UpdateUserAsync(User user, int id);
    }
}
