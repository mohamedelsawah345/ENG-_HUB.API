using ENG__HUB.API.Models;
using ENG__HUB.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ENG__HUB.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IGenericService<Department> _departmentservice;

        public DepartmentsController(IGenericService<Department> departmentservice)
        {
            _departmentservice = departmentservice;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _departmentservice.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var dept = await _departmentservice.GetByIdAsync(id);
            return dept == null ? NotFound() : Ok(dept);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Department dept)
        {
            var created = await _departmentservice.AddAsync(dept);
            return CreatedAtAction(nameof(GetById), new { id = created.DepartmentID }, created);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Department dept)
        {
            if (id != dept.DepartmentID)
                return BadRequest("ID mismatch");

            var existing = await _departmentservice.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            var updated = await _departmentservice.UpdateAsync(dept);
            return updated ? NoContent() : StatusCode(500, "Update failed");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _departmentservice.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
