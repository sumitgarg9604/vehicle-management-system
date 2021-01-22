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
    public class VehicleTypesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VehicleTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/VehicleTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleTypes>>> GetVehicleTypes()
        {
            return await _context.VehicleTypes.ToListAsync();
        }

        // GET: api/VehicleTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleTypes>> GetVehicleTypes(string id)
        {
            var vehicleTypes = await _context.VehicleTypes.FindAsync(id);

            if (vehicleTypes == null)
            {
                return NotFound();
            }

            return vehicleTypes;
        }

        // PUT: api/VehicleTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleTypes(string id, VehicleTypes vehicleTypes)
        {
            if (id != vehicleTypes.VehicleType)
            {
                return BadRequest();
            }

            _context.Entry(vehicleTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehicleTypesExists(id))
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

        // POST: api/VehicleTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VehicleTypes>> PostVehicleTypes(VehicleTypes vehicleTypes)
        {
            _context.VehicleTypes.Add(vehicleTypes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VehicleTypesExists(vehicleTypes.VehicleType))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetVehicleTypes", new { id = vehicleTypes.VehicleType }, vehicleTypes);
        }

        // DELETE: api/VehicleTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VehicleTypes>> DeleteVehicleTypes(string id)
        {
            var vehicleTypes = await _context.VehicleTypes.FindAsync(id);
            if (vehicleTypes == null)
            {
                return NotFound();
            }

            _context.VehicleTypes.Remove(vehicleTypes);
            await _context.SaveChangesAsync();

            return vehicleTypes;
        }

        private bool VehicleTypesExists(string id)
        {
            return _context.VehicleTypes.Any(e => e.VehicleType == id);
        }
    }
}
