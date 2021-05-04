using API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Repositories
{
    public interface IAssignmentRepository 
    {
        Task<IEnumerable<Assignment>> GetAllAssignmentsAsync();

        Task AddNewAssignmentAsync(Assignment assignment);

        Task<Assignment> GetAssignmentByIdAsync(int id);

        Task<bool> UpdateAssignmentAsync(int id, Assignment assignment);

        Task<bool> DeleteAssignmentAsync(int id);

        Task<IEnumerable<Assignment>> GetAssignmentsByStatusIdAsync(int id);
    }
}
