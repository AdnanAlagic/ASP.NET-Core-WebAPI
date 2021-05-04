using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreateDTO, User>();
            CreateMap<User, UserGetDTO>();
        }
    }
}
