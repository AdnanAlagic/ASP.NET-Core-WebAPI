using API.Database;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly AssignmentContext _context;

        public AssignmentRepository(AssignmentContext context)
        {
            _context = context;
        }

        public async Task<bool> UpdateAssignmentAsync(int id, Assignment assignment)
        {
            var assignmentToUpdate = await GetAssignmentByIdAsync(id);
            if (assignmentToUpdate is not null)
            {
                assignmentToUpdate.AssignmentTitle = assignment.AssignmentTitle;
                assignmentToUpdate.AssignmentDescription = assignment.AssignmentDescription;
                assignmentToUpdate.AssignmentStartDate = assignment.AssignmentStartDate;
                assignmentToUpdate.AssignmentEndDate = assignment.AssignmentEndDate;
                assignmentToUpdate.AssignmentStatusId = assignment.AssignmentStatusId;
                assignmentToUpdate.AssignmentPriorityId = assignment.AssignmentPriorityId;
                assignmentToUpdate.AssignmentUserId = assignment.AssignmentUserId;
                assignmentToUpdate.AssignmentIsDeleted = assignment.AssignmentIsDeleted;
                assignmentToUpdate.AssignmentPhotoAttach = assignment.AssignmentPhotoAttach;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task AddNewAssignmentAsync(Assignment assignment)
        {
            await _context.Assignments.AddAsync(assignment);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Assignment>> GetAllAssignmentsAsync()
        {
             return await _context.Assignments
                .Include(assignment => assignment.UserAssignment)
                .Include(priority=> priority.PriorityAssignment)
                .Include(status=>status.StatusAssignment)
                .Where(assignment => !assignment.AssignmentIsDeleted)
                .ToListAsync();
        }

       public async Task<Assignment>GetAssignmentByIdAsync(int id)
        {
            var assignmentToReturn = await _context.Assignments
                .Include(assignment => assignment.UserAssignment)
                .Include(priority => priority.PriorityAssignment)
                .Include(status => status.StatusAssignment)
                .FirstOrDefaultAsync(assignment => assignment.AssignmentId == id && !assignment.AssignmentIsDeleted);
            return assignmentToReturn;
        }

        public async Task<bool> DeleteAssignmentAsync(int id)
        {
            var assignmentToDelete = await GetAssignmentByIdAsync(id);
            if (assignmentToDelete is not null)
            {
                assignmentToDelete.AssignmentIsDeleted = true;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Assignment>> GetAssignmentsByStatusIdAsync(int id)
        {
            return await _context.Assignments
                .Include(assignment => assignment.UserAssignment)
                .Include(priority => priority.PriorityAssignment)
                .Include(status => status.StatusAssignment)
                .Where(assignment => !assignment.AssignmentIsDeleted && assignment.AssignmentStatusId == id)
                .ToListAsync();
        }
    }
}
