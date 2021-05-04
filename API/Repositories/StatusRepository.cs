using API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Database;

namespace API.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private readonly AssignmentContext _context;

        public StatusRepository(AssignmentContext context)
        {
            _context = context;
        }

        public async Task AddStatusAssignmentAsync(Status status)
        {
            await _context.AddAsync(status);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Status>>  GetAllStatusAssignmentAsync()
        {
            return await _context.Statuses.ToListAsync();
        }
    }
}
