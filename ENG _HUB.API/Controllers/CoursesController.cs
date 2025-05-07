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
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var courses = await _courseService.GetAllAsync(cancellationToken);
            return Ok(courses.Adapt<IEnumerable<CourseResponse>>());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id, CancellationToken cancellationToken)
        {
            var course = await _courseService.GetByIdAsync(id, cancellationToken);
            return course == null ? NotFound() : Ok(course.Adapt<CourseResponse>());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CourseRequest courseRequest, CancellationToken cancellationToken)
        {
            var created = await _courseService.AddAsync(courseRequest.Adapt<Course>(), cancellationToken);
            return CreatedAtAction(nameof(GetById), new { id = created.ID }, created.Adapt<CourseResponse>());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CourseRequest courseRequest, CancellationToken cancellationToken)
        {
            var existing = await _courseService.GetByIdAsync(id, cancellationToken);
            if (existing == null)
                return NotFound();

            var updated = await _courseService.UpdateAsync(courseRequest.Adapt<Course>(), cancellationToken);
            return updated ? NoContent() : StatusCode(500, "Update failed");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var deleted = await _courseService.DeleteAsync(id, cancellationToken);
            return deleted ? NoContent() : NotFound();
        }
    }
}
