using ENG__HUB.API.Contract.Departments;

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
        public async Task<IActionResult> GetAll()
        {
            var Departments = await _departmentservice.GetAllAsync();
            return Ok(Departments.Adapt<IEnumerable<DepartmentResponse>>());


        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var dept = await _departmentservice.GetByIdAsync(id);
            return dept == null ? NotFound() : Ok(dept.Adapt<DepartmentResponse>());
        }

        [HttpPost]
        public async Task<IActionResult> Create(DepartmentRequest dept)
        {
            var created = await _departmentservice.AddAsync(dept.Adapt<Department>());
            return CreatedAtAction(nameof(GetById), new { id = created.ID }, created.Adapt<DepartmentResponse>());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, DepartmentRequest dept)
        {

            var existing = await _departmentservice.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            var updated = await _departmentservice.UpdateAsync(dept.Adapt<Department>());
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
