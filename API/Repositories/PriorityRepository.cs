using API.Database;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class PriorityRepository : IPriorityRepository
    {
        private readonly AssignmentContext _context;

        public PriorityRepository(AssignmentContext context)
        {
            _context = context;
        }

        public async Task AddNewPriorityAsync(Priority priority)
        {
            await _context.AddAsync(priority);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Priority>> GetAllPriorityAssignmentAsync()
        {
            return await _context.Priorities.ToListAsync();
        }
    }
}
