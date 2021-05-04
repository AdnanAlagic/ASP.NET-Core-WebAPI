using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.MappingProfiles
{
    public class StatusProfile : Profile
    {
        public StatusProfile()
        {
            CreateMap<Status, StatusGetDTO>();
            CreateMap<StatusCreateDTO, Status>();
        }
    }
}
