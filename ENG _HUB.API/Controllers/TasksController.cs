using ENG__HUB.API.Contract.ToDoList;

namespace ENG__HUB.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly IGenericService<ToDoList> _ToDoListService;

        public TasksController(IGenericService<ToDoList> ToDoListService)
        {
            _ToDoListService = ToDoListService;   
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tasks = await _ToDoListService.GetAllAsync();
            

            return Ok(tasks.Adapt<IEnumerable<ToDoListResponse>>());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var task = await _ToDoListService.GetByIdAsync(id);
            return task == null ? NotFound() : Ok(task.Adapt<ToDoListResponse>());
        }

        [HttpPost]
        public async Task<IActionResult> Create(ToDoListRequest task)
        {
            var created = await _ToDoListService.AddAsync(task.Adapt<ToDoList>());
            return CreatedAtAction(nameof(GetById), new { id = created.ID }, created.Adapt<ToDoListResponse>());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ToDoListRequest task)
        {
           

            var existing = await _ToDoListService.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            var updated = await _ToDoListService.UpdateAsync(task.Adapt<ToDoList>());
            return updated ? NoContent() : StatusCode(500, "Update failed");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _ToDoListService.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
