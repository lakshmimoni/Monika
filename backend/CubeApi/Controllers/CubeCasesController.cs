using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CubeApi.Data;
using CubeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CubeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CubeCasesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CubeCasesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CubeCase>>> GetCubeCases()
        {
            return await _context.CubeCases.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CubeCase>> GetCubeCase(int id)
        {
            var cubeCase = await _context.CubeCases.FindAsync(id);

            if (cubeCase == null)
            {
                return NotFound();
            }

            return cubeCase;
        }

        [HttpPost]
        public async Task<ActionResult<CubeCase>> PostCubeCase(CubeCase cubeCase)
        {
            _context.CubeCases.Add(cubeCase);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCubeCase), new { id = cubeCase.Id }, cubeCase);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCubeCase(int id, CubeCase cubeCase)
        {
            if (id != cubeCase.Id)
            {
                return BadRequest();
            }

            _context.Entry(cubeCase).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCubeCase(int id)
        {
            var cubeCase = await _context.CubeCases.FindAsync(id);
            if (cubeCase == null)
            {
                return NotFound();
            }

            _context.CubeCases.Remove(cubeCase);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
