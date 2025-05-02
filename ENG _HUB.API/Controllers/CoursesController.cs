using ENG__HUB.API.Models;
using ENG__HUB.API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ENG__HUB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IGenericService<Course> _courseService;

        public CoursesController(IGenericService<Course> courseService)
        {
            _courseService = courseService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _courseService.GetAllAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var course = await _courseService.GetByIdAsync(id);
            return course == null ? NotFound() : Ok(course);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Course course)
        {
            var created = await _courseService.AddAsync(course);
            return CreatedAtAction(nameof(GetById), new { id = created.CourseID }, created);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Course course)
        {
            if (id != course.CourseID)
                return BadRequest("ID mismatch");

            var existing = await _courseService.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            var updated = await _courseService.UpdateAsync(course);
            return updated ? NoContent() : StatusCode(500, "Update failed");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _courseService.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
