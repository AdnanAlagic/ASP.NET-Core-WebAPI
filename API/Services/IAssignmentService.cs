using API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IAssignmentService
    {
        Task<IEnumerable<AssignmentGetDTO>> GetAllAssignmentsAsync();

        Task AddNewAssignmentAsync(AssignmentCreateDTO assignment);

        Task<AssignmentGetDTO> GetAssignmentByIdAsync(int id);

        Task<bool> UpdateAssignmentAsync(int id, AssignmentUpdateDTO assignment);
         
        Task<bool> DeleteAssignmentAsync(int id);

        Task<IEnumerable<AssignmentGetDTO>> GetAssignmentsByStatusIdAsync(int id);
    }
}
