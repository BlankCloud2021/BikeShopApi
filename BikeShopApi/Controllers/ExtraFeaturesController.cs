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
    public class ExtraFeaturesController : ControllerBase
    {
        private readonly BikeShopApiDbContext _context;

        public ExtraFeaturesController(BikeShopApiDbContext context)
        {
            _context = context;
        }

        // GET: api/ExtraFeatures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExtraFeature>>> GetExtraFeatures()
        {
            return await _context.ExtraFeatures.ToListAsync();
        }

        // GET: api/ExtraFeatures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExtraFeature>> GetExtraFeature(int id)
        {
            var extraFeature = await _context.ExtraFeatures.FindAsync(id);

            if (extraFeature == null)
            {
                return NotFound();
            }

            return extraFeature;
        }

        // PUT: api/ExtraFeatures/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExtraFeature(int id, ExtraFeature extraFeature)
        {
            if (id != extraFeature.Id)
            {
                return BadRequest();
            }

            _context.Entry(extraFeature).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtraFeatureExists(id))
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

        // POST: api/ExtraFeatures
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExtraFeature>> PostExtraFeature(ExtraFeature extraFeature)
        {
            _context.ExtraFeatures.Add(extraFeature);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExtraFeature", new { id = extraFeature.Id }, extraFeature);
        }

        // DELETE: api/ExtraFeatures/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExtraFeature(int id)
        {
            var extraFeature = await _context.ExtraFeatures.FindAsync(id);
            if (extraFeature == null)
            {
                return NotFound();
            }

            _context.ExtraFeatures.Remove(extraFeature);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExtraFeatureExists(int id)
        {
            return _context.ExtraFeatures.Any(e => e.Id == id);
        }
    }
}
