using BPKBapi.Models;
using BPKBapi.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BPKBapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BPKBController : Controller
    {
        private readonly AppDbContext _context;

        public BPKBController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertTrBpkb([FromBody] BPKB trBpkb)
        {
            if (trBpkb == null)
            {
                return BadRequest("Invalid data.");
            }

            trBpkb.created_on = DateTime.UtcNow;
            trBpkb.last_updated_on = DateTime.UtcNow;

            _context.tr_bpkb.Add(trBpkb);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }

            return Ok("Data inserted successfully.");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<listBPKB>>> GetBpkbs()
        {
            var res = await _context.tr_bpkb.ToListAsync();
            return Ok(res);
        }
    }
}
