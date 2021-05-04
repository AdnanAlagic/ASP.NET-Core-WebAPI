using API.DTOs;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/Statuses")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _service;

        public StatusController(IStatusService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStatusesAsync()
        {
            var allStatuses = await _service.GetAllStatusAssignmentAsync();
            return Ok(allStatuses);
        }

        [HttpPost("NewStatus")]
        public async Task<IActionResult> AddNewStatusAsync(StatusCreateDTO status)
        {
            await _service.AddNewStatusAsync(status);
            return Ok();
        }
    }
}
