using API.DTOs;
using API.Models;
using API.Repositories;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _repository;
        private readonly IMapper _mapper;

        public StatusService(IStatusRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddNewStatusAsync(StatusCreateDTO status)
        {
            await _repository.AddStatusAssignmentAsync(_mapper.Map<Status>(status));
        }

        public async Task<IEnumerable<StatusGetDTO>> GetAllStatusAssignmentAsync()
        {
            var allStatuses = await _repository.GetAllStatusAssignmentAsync();
            return _mapper.Map<IEnumerable<StatusGetDTO>>(allStatuses);
        }
    }
}
