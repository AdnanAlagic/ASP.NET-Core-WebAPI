using API.DTOs;
using API.Models;
using API.Repositories;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class AssignmentService : IAssignmentService
    {
        private readonly IAssignmentRepository _repository;
        private readonly IMapper _mapper;

        public AssignmentService(IAssignmentRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AssignmentGetDTO>> GetAllAssignmentsAsync()
        {
            var allAssignments =  await _repository.GetAllAssignmentsAsync();
            return _mapper.Map<IEnumerable<AssignmentGetDTO>>(allAssignments);
        }

       public async Task AddNewAssignmentAsync(AssignmentCreateDTO assignment)
        {
            var newAssignment = _mapper.Map<Assignment>(assignment);
            await _repository.AddNewAssignmentAsync(newAssignment);
        }

        public async Task<AssignmentGetDTO> GetAssignmentByIdAsync(int id)
        {
            var assignmentToReturn = await _repository.GetAssignmentByIdAsync(id);
            return _mapper.Map<AssignmentGetDTO>(assignmentToReturn);
        }

        public async Task<bool> UpdateAssignmentAsync(int id, AssignmentUpdateDTO assignmentUpdate)
        {
            var assignment = _mapper.Map<Assignment>(assignmentUpdate);
            return await _repository.UpdateAssignmentAsync(id, assignment);
        }

        public async Task<bool> DeleteAssignmentAsync(int id)
        {
            return await _repository.DeleteAssignmentAsync(id);
        }

        public async Task<IEnumerable<AssignmentGetDTO>> GetAssignmentsByStatusIdAsync(int id)
        {
            var assignmentsFilterByStatus = await _repository.GetAssignmentsByStatusIdAsync(id);
            return _mapper.Map<IEnumerable<AssignmentGetDTO>>(assignmentsFilterByStatus);
        }
    }
}
