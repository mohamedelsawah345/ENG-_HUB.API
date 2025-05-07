namespace ENG__HUB.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly IGenericService<Note> _noteservice;

        public NotesController(IGenericService<Note> noteservice)
        {
            _noteservice = noteservice;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _noteservice.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var note = await _noteservice.GetByIdAsync(id);
            return note == null ? NotFound() : Ok(note);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Note note)
        {
            var created = await _noteservice.AddAsync(note);
            return CreatedAtAction(nameof(GetById), new { id = created.NoteID }, created);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Note note)
        {
            if (id != note.NoteID)
                return BadRequest("ID mismatch");

            var existing = await _noteservice.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            var updated = await _noteservice.UpdateAsync(note);
            return updated ? NoContent() : StatusCode(500, "Update failed");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _noteservice.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
