using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIOPortunidade.Data;
using Oportunidade;

namespace APIOPortunidade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OportunidadeController : ControllerBase
    {
        private readonly APIOPortunidadeContext _context;

        public OportunidadeController(APIOPortunidadeContext context)
        {
            _context = context;
        }

        // GET: api/Oportunidade
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OportunidadeModel>>> GetOportunidadeModel()
        {
          if (_context.OportunidadeModel == null)
          {
              return NotFound();
          }
            return await _context.OportunidadeModel.ToListAsync();
        }

        // GET: api/Oportunidade/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OportunidadeModel>> GetOportunidadeModel(int id)
        {
          if (_context.OportunidadeModel == null)
          {
              return NotFound();
          }
            var oportunidadeModel = await _context.OportunidadeModel.FindAsync(id);

            if (oportunidadeModel == null)
            {
                return NotFound();
            }

            return oportunidadeModel;
        }

        // PUT: api/Oportunidade/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOportunidadeModel(int id, OportunidadeModel oportunidadeModel)
        {
            if (id != oportunidadeModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(oportunidadeModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OportunidadeModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Oportunidade
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OportunidadeModel>> PostOportunidadeModel(OportunidadeModel oportunidadeModel)
        {
          if (_context.OportunidadeModel == null)
          {
              return Problem("Entity set 'APIOPortunidadeContext.OportunidadeModel'  is null.");
          }
            _context.OportunidadeModel.Add(oportunidadeModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOportunidadeModel", new { id = oportunidadeModel.Id }, oportunidadeModel);
        }

        // DELETE: api/Oportunidade/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOportunidadeModel(int id)
        {
            if (_context.OportunidadeModel == null)
            {
                return NotFound();
            }
            var oportunidadeModel = await _context.OportunidadeModel.FindAsync(id);
            if (oportunidadeModel == null)
            {
                return NotFound();
            }

            _context.OportunidadeModel.Remove(oportunidadeModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OportunidadeModelExists(int id)
        {
            return (_context.OportunidadeModel?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
