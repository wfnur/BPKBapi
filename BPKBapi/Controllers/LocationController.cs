using BPKBapi.Models;
using BPKBapi.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BPKBapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly AppDbContext _context;

        public LocationController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StorageLocation>>> GetLocations()
        {
            var res = await _context.ms_storage_locations.ToListAsync();
            return Ok(res);
        }
    }
}
