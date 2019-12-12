using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice_Project.Data;
using Practice_Project.Models;

namespace Practice_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MelangePurchaseApiController : ControllerBase
    {
        private readonly MelangePurchaseContext _context;

        public MelangePurchaseApiController(MelangePurchaseContext context)
        {
            _context = context;
        }

        // GET: api/MelangePurchaseApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MelangePurchase>>> GetMelangePurchase()
        {
            return await _context.MelangePurchase.ToListAsync();
        }

        // GET: api/MelangePurchaseApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MelangePurchase>> GetMelangePurchase(int id)
        {
            var melangePurchase = await _context.MelangePurchase.FindAsync(id);

            if (melangePurchase == null)
            {
                return NotFound();
            }

            return melangePurchase;
        }

        // PUT: api/MelangePurchaseApi/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMelangePurchase(int id, MelangePurchase melangePurchase)
        {
            if (id != melangePurchase.Id)
            {
                return BadRequest();
            }

            _context.Entry(melangePurchase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MelangePurchaseExists(id))
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

        // POST: api/MelangePurchaseApi
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<MelangePurchase>> PostMelangePurchase(MelangePurchase melangePurchase)
        {
            _context.MelangePurchase.Add(melangePurchase);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMelangePurchase", new { id = melangePurchase.Id }, melangePurchase);
        }

        // DELETE: api/MelangePurchaseApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MelangePurchase>> DeleteMelangePurchase(int id)
        {
            var melangePurchase = await _context.MelangePurchase.FindAsync(id);
            if (melangePurchase == null)
            {
                return NotFound();
            }

            _context.MelangePurchase.Remove(melangePurchase);
            await _context.SaveChangesAsync();

            return melangePurchase;
        }

        private bool MelangePurchaseExists(int id)
        {
            return _context.MelangePurchase.Any(e => e.Id == id);
        }
    }
}
