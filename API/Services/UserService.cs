using API.DTOs;
using API.Models;
using API.Repositories;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class UserService : IUserService
    {
       private readonly IUserRepository _repository;
       private readonly IMapper _mapper;

       public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task AddNewUserAssignmentAsync(UserCreateDTO user)
        {
            var newUser = _mapper.Map<User>(user);
            await _repository.AddNewUserAsync(newUser);
        }

        public async Task<bool> DeleteUserByIdAsync(int id)
        {
            return await _repository.DeleteUserAsync(id);
        }

        public async Task<IEnumerable<UserGetDTO>>  GetAllUserAssignmentAsync()
        {
            var allUsers = await _repository.GetAllUserAssignmentAsync();
            return _mapper.Map<IEnumerable<UserGetDTO>>(allUsers);
        }

        public async Task<bool> UpadateUserByIdAsync(UserCreateDTO user,int id)
        {
            if (user is not null)
            {
                var userUpdate = _mapper.Map<User>(user);
                return await _repository.UpdateUserAsync(userUpdate, id);
            }
            return false;
        }
    }
}
