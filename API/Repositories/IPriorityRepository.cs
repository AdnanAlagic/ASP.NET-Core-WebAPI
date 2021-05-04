using API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Repositories
{
    public interface IPriorityRepository
    {
        Task<IEnumerable<Priority>> GetAllPriorityAssignmentAsync();

        Task AddNewPriorityAsync(Priority priority);
    }
}
