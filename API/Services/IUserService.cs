using API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserGetDTO>> GetAllUserAssignmentAsync();

        Task AddNewUserAssignmentAsync(UserCreateDTO user);

        Task<bool> DeleteUserByIdAsync(int id);

        Task<bool> UpadateUserByIdAsync(UserCreateDTO user, int id);
    }
}
