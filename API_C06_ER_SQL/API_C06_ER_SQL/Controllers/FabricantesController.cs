using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EX1.Models;

namespace API_C06_ER_SQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FabricantesController : ControllerBase
    {
        private readonly APIContext _context;

        public FabricantesController(APIContext context)
        {
            _context = context;
        }

        // GET: api/Fabricantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fabricante>>> GetFabricante()
        {
            return await _context.Fabricante.ToListAsync();
        }

        // GET: api/Fabricantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fabricante>> GetFabricante(int id)
        {
            var fabricante = await _context.Fabricante.FindAsync(id);

            if (fabricante == null)
            {
                return NotFound();
            }

            return fabricante;
        }

        // PUT: api/Fabricantes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFabricante(int id, Fabricante fabricante)
        {
            if (id != fabricante.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(fabricante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FabricanteExists(id))
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

        // POST: api/Fabricantes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Fabricante>> PostFabricante(Fabricante fabricante)
        {
            _context.Fabricante.Add(fabricante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFabricante", new { id = fabricante.Codigo }, fabricante);
        }

        // DELETE: api/Fabricantes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fabricante>> DeleteFabricante(int id)
        {
            var fabricante = await _context.Fabricante.FindAsync(id);
            if (fabricante == null)
            {
                return NotFound();
            }

            _context.Fabricante.Remove(fabricante);
            await _context.SaveChangesAsync();

            return fabricante;
        }

        private bool FabricanteExists(int id)
        {
            return _context.Fabricante.Any(e => e.Codigo == id);
        }
    }
}
