using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.MappingProfiles
{
    public class AssignmentProfile : Profile
    {
        public AssignmentProfile()
        {
            CreateMap<AssignmentCreateDTO, Assignment>();
            CreateMap<Assignment, AssignmentGetDTO>();
            CreateMap<AssignmentUpdateDTO, Assignment>();
        }
    }
}
