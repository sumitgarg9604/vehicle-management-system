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
    public class AdTypesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AdTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdTypes>>> GetAdTypes()
        {
            return await _context.AdTypes.ToListAsync();
        }

        // GET: api/AdTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdTypes>> GetAdTypes(string id)
        {
            var adTypes = await _context.AdTypes.FindAsync(id);

            if (adTypes == null)
            {
                return NotFound();
            }

            return adTypes;
        }

        // PUT: api/AdTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdTypes(string id, AdTypes adTypes)
        {
            if (id != adTypes.adType)
            {
                return BadRequest();
            }

            _context.Entry(adTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdTypesExists(id))
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

        // POST: api/AdTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AdTypes>> PostAdTypes(AdTypes adTypes)
        {
            _context.AdTypes.Add(adTypes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AdTypesExists(adTypes.adType))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAdTypes", new { id = adTypes.adType }, adTypes);
        }

        // DELETE: api/AdTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AdTypes>> DeleteAdTypes(string id)
        {
            var adTypes = await _context.AdTypes.FindAsync(id);
            if (adTypes == null)
            {
                return NotFound();
            }

            _context.AdTypes.Remove(adTypes);
            await _context.SaveChangesAsync();

            return adTypes;
        }

        private bool AdTypesExists(string id)
        {
            return _context.AdTypes.Any(e => e.adType == id);
        }
    }
}
