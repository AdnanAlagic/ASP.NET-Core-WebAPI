using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models;

namespace API.Repositories
{
    public interface IStatusRepository

    {
        Task<IEnumerable<Status>> GetAllStatusAssignmentAsync();

        Task AddStatusAssignmentAsync(Status status);
    }
}
