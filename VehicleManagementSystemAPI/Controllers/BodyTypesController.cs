using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VehicleManagementSystemAPI.Models;

namespace VehicleManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyTypesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BodyTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/BodyTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BodyTypes>>> GetBodyTypes()
        {
            return await _context.BodyTypes.ToListAsync();
        }

        // GET: api/BodyTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BodyTypes>> GetBodyTypes(string id)
        {
            var bodyTypes = await _context.BodyTypes.FindAsync(id);

            if (bodyTypes == null)
            {
                return NotFound();
            }

            return bodyTypes;
        }

        // PUT: api/BodyTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBodyTypes(string id, BodyTypes bodyTypes)
        {
            if (id != bodyTypes.bodyType)
            {
                return BadRequest();
            }

            _context.Entry(bodyTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BodyTypesExists(id))
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

        // POST: api/BodyTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BodyTypes>> PostBodyTypes(BodyTypes bodyTypes)
        {
            _context.BodyTypes.Add(bodyTypes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BodyTypesExists(bodyTypes.bodyType))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBodyTypes", new { id = bodyTypes.bodyType }, bodyTypes);
        }

        // DELETE: api/BodyTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BodyTypes>> DeleteBodyTypes(string id)
        {
            var bodyTypes = await _context.BodyTypes.FindAsync(id);
            if (bodyTypes == null)
            {
                return NotFound();
            }

            _context.BodyTypes.Remove(bodyTypes);
            await _context.SaveChangesAsync();

            return bodyTypes;
        }

        private bool BodyTypesExists(string id)
        {
            return _context.BodyTypes.Any(e => e.bodyType == id);
        }
    }
}
