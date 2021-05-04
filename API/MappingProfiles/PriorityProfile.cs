using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.MappingProfiles
{
    public class PriorityProfile : Profile
    {
        public PriorityProfile()
        {
            CreateMap<Priority, PriorityGetDTO>();
            CreateMap<PriorityCreateDTO, Priority>();
        }
    }
}
