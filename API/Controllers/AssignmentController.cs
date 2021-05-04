using API.DTOs;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/Assignments")]
    [ApiController]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService _service;

        public AssignmentController(IAssignmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAssignmentsAsync()
        {
            var allAssignments = await _service.GetAllAssignmentsAsync();
            return Ok(allAssignments);
        }

        [HttpPost("NewAssignment")]
        public async Task<IActionResult>AddTaskAsync([FromBody] AssignmentCreateDTO assignment)
        {
            await _service.AddNewAssignmentAsync(assignment);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>GetAssignmentByIdAsync(int id)
        {
            var assignment = await _service.GetAssignmentByIdAsync(id);
            if (assignment is null)
            {
                return NotFound();
            }
            return Ok(assignment);
        }

        [HttpPut("UpdateAssignment/{id}")]
        public async Task<IActionResult>UpdateTaskAsync(int id, [FromBody] AssignmentUpdateDTO assignment)
        {
            var isUpdated = await _service.UpdateAssignmentAsync(id, assignment);
            if (!isUpdated)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPut("DeleteAssignment/{id}")]
        public async Task<IActionResult> DeleteAssignmentAsync(int id)
        {
            var isDeleted = await _service.DeleteAssignmentAsync(id);
            if (!isDeleted)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpGet("Status/{id}")]
        public async Task<IActionResult>GetAssignmentsByStatusIdAsync(int id)
        {
            var assingmentsFilterByStatus = await _service.GetAssignmentsByStatusIdAsync(id);
            if (assingmentsFilterByStatus is null)
            {
                return NotFound();
            }
            return Ok(assingmentsFilterByStatus);
        }
    }
}
