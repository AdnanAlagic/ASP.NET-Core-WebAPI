using API.DTOs;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/Priorities")]
    [ApiController]
    public class PriorityController : ControllerBase
    {
        private readonly IPriorityService _service;

        public PriorityController(IPriorityService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPriorityAssignmentAsync()
        {
            var allPriorities = await _service.GetAllPriorityAssignmentAsync();
            return Ok(allPriorities);
        }

        [HttpPost("NewPriority")]
        public async Task<IActionResult> AddNewPriorityAsync(PriorityCreateDTO priority)
        {
            await _service.AddNewPriorityAsync(priority);
            return Ok();
        }
    }
}
