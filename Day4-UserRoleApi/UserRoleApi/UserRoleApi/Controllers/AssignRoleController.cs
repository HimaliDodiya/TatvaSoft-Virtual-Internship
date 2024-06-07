using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UserRoleApi.Models;
using UserRoleApi.Services;

namespace UserRoleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignRoleController : ControllerBase
    {
        private readonly IAssignRoleService _assignRoleService;

        public AssignRoleController(IAssignRoleService assignRoleService)
        {
            _assignRoleService = assignRoleService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserRoleAssignment>> GetAllAssignments()
        {
            var assignments = _assignRoleService.GetAllAssignments();
            return Ok(assignments);
        }

        [HttpPost]
        public ActionResult<UserRoleAssignment> AssignRole(UserRoleAssignment assignment)
        {
            _assignRoleService.AssignRole(assignment);
            return CreatedAtAction(nameof(GetAssignmentById), new { id = assignment.Id }, assignment);
        }

        [HttpGet("{id}")]
        public ActionResult<UserRoleAssignment> GetAssignmentById(int id)
        {
            var assignment = _assignRoleService.GetAssignmentById(id);
            if (assignment == null)
            {
                return NotFound();
            }
            return Ok(assignment);
        }

        // Implement other CRUD endpoints for UserRoleAssignment
    }
}
