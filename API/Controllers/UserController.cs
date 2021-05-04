using API.DTOs;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var allUsers = await _service.GetAllUserAssignmentAsync();
            return Ok(allUsers);
        }

        [HttpPost("NewUser")]
        public async Task<IActionResult> AddNewUserAsync(UserCreateDTO user)
        {
            await _service.AddNewUserAssignmentAsync(user);
            return Ok();
        }

        [HttpPut("DeleteUser/{id}")]
        public async Task<IActionResult>DeleteUserByIdAsync(int id)
        {
            if (await _service.DeleteUserByIdAsync(id))
            {
                return Ok();
            }
            return NotFound();
        }

        [HttpPut("UpdateUser/{id}")]
        public async Task<IActionResult> UpdateUserAsync([FromBody]UserCreateDTO user, int id)
        {
            if (await _service.UpadateUserByIdAsync(user, id))
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
