using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BikeShopApi.Models;

namespace BikeShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeShopsController : ControllerBase
    {
        private readonly BikeShopApiDbContext _context;

        public BikeShopsController(BikeShopApiDbContext context)
        {
            _context = context;
        }

        // GET: api/BikeShops
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BikeShop>>> GetBikeShops()
        {
            return await _context.BikeShops.ToListAsync();
        }

        // GET: api/BikeShops/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BikeShop>> GetBikeShop(int id)
        {
            var bikeShop = await _context.BikeShops.FindAsync(id);

            if (bikeShop == null)
            {
                return NotFound();
            }

            return bikeShop;
        }

        // PUT: api/BikeShops/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBikeShop(int id, BikeShop bikeShop)
        {
            if (id != bikeShop.Id)
            {
                return BadRequest();
            }

            _context.Entry(bikeShop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BikeShopExists(id))
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

        // POST: api/BikeShops
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BikeShop>> PostBikeShop(BikeShop bikeShop)
        {
            _context.BikeShops.Add(bikeShop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBikeShop", new { id = bikeShop.Id }, bikeShop);
        }

        // DELETE: api/BikeShops/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBikeShop(int id)
        {
            var bikeShop = await _context.BikeShops.FindAsync(id);
            if (bikeShop == null)
            {
                return NotFound();
            }

            _context.BikeShops.Remove(bikeShop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BikeShopExists(int id)
        {
            return _context.BikeShops.Any(e => e.Id == id);
        }
    }
}
