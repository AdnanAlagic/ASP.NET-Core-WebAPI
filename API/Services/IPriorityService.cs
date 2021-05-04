using API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IPriorityService
    {
        Task<IEnumerable<PriorityGetDTO>> GetAllPriorityAssignmentAsync();

        Task AddNewPriorityAsync(PriorityCreateDTO priority);
    }
}
