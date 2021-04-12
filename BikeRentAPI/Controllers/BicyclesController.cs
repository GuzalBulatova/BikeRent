using System.Collections.Generic;
using BikeRent.Data;
using BikeRent.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace BikeRentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BicyclesController : ControllerBase
    {
        private readonly BikeRentContext _context;
        public BicyclesController(BikeRentContext context)
        {
            _context = context;
        }

        // GET all Bicycles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bicycle>>> GetBicycles()
        {
            return await _context.Bicycles.ToListAsync();
        }

        // GET a Bicycle by its Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Bicycle>> GetBicycle(int id)
        {
            var bike = await _context.Bicycles.FindAsync(id);

            if (bike == null)
            {
                return NotFound();
            }

            return bike;
        }

        // POST to add a new Bicycle
        [HttpPost]
        public async Task<ActionResult<Bicycle>> PostBicycle(Bicycle bicycle)
        {
            _context.Bicycles.Add(bicycle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBicycle", new { id = bicycle.BicycleId }, bicycle);
        }

        // PUT rest method to update a Bicycle
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBicycle(int id, Bicycle bicycle)
        {
            if (id != bicycle.BicycleId)
            {
                return BadRequest();
            }
            _context.Entry(bicycle).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BicycleExists(id))
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

        // DELETE a Bicycle from the database by Id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBicycle(int id)
        {
            var bicycle = await _context.Bicycles.FindAsync(id);
            if (bicycle == null)
            {
                return NotFound();
            }

            _context.Bicycles.Remove(bicycle);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // DELETE Rentals by id for bicycle
        //[HttpDelete("sproc/{id}")] 
        //public async Task<ActionResult<string>> DeleteRentalsForBicycle(int id)
        //{
        //    var rowsAffected = await _context.Database
        //        .ExecuteSqlInterpolatedAsync($"EXEC DeleteRentalsForBicycle {id}");
        //    return $"{rowsAffected} Rentals Deleted";
        //}
        private bool BicycleExists(int id)
        {
            return _context.Bicycles.Any(e => e.BicycleId == id);
        }
    }
}
