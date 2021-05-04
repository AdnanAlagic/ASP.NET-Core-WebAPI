using API.DTOs;
using API.Models;
using API.Repositories;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class PriorityService : IPriorityService
    {
        private readonly IPriorityRepository _repository;
        private readonly IMapper _mapper;

        public PriorityService(IPriorityRepository repository,IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddNewPriorityAsync(PriorityCreateDTO priority)
        {
            await _repository.AddNewPriorityAsync(_mapper.Map<Priority>(priority));
        }

        public async Task<IEnumerable<PriorityGetDTO>> GetAllPriorityAssignmentAsync()
        {
            var allPriorities = await _repository.GetAllPriorityAssignmentAsync();
            return _mapper.Map<IEnumerable<PriorityGetDTO>>(allPriorities);
        }
    }
}
