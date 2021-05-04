using API.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IStatusService
    {
        Task<IEnumerable<StatusGetDTO>> GetAllStatusAssignmentAsync();

        Task AddNewStatusAsync(StatusCreateDTO status);
    }
}
