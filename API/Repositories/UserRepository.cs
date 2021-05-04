using API.Database;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AssignmentContext _context;

        public UserRepository(AssignmentContext context)
        {
            _context = context;
        }

        public async Task AddNewUserAsync(User user)
        {
            await _context.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var userToDelete = await GetUserByIdAsync(id);
            if (userToDelete is not null)
            {
                userToDelete.IsDeleted = true;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<User>> GetAllUserAssignmentAsync()
        {
            return await _context.Users
                .Where(user => !user.IsDeleted)
                .ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var userToReturn = await _context.Users
                .FirstOrDefaultAsync(user => user.UserId == id && !user.IsDeleted);
            return userToReturn;
        }   

        public async Task<bool> UpdateUserAsync(User user, int id)
        {
            var userToUpdate = await GetUserByIdAsync(id);
            if (userToUpdate is not null)
            {
                userToUpdate.UserFirstName = user.UserFirstName;
                userToUpdate.UserLastName = user.UserLastName;
                await _context.SaveChangesAsync() ;
                return true;
            }
            return false;
        }
    }
}
