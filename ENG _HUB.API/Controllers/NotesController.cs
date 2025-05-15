using ENG__HUB.API.Contract.Note;

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
        public async Task<IActionResult> GetAll()
        {
            var Notes = await _noteservice.GetAllAsync();
            return Ok(Notes.Adapt<IEnumerable<NoteResponse>>());

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var note = await _noteservice.GetByIdAsync(id);
            return note == null ? NotFound() : Ok(note.Adapt<NoteResponse>());
        }

        [HttpPost]
        public async Task<IActionResult> Create(NoteRequest note)
        {
            var created = await _noteservice.AddAsync(note.Adapt<Note>());
            return CreatedAtAction(nameof(GetById), new { id = created.ID }, created.Adapt<NoteResponse>());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, NoteRequest note)
        {
            
            var existing = await _noteservice.GetByIdAsync(id);
            if (existing == null)
                return NotFound();

            var updated = await _noteservice.UpdateAsync(note.Adapt<Note>());
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
