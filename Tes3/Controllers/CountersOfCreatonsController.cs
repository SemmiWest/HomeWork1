using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tes3.Entites;
using Tes3.Tes3.Infrastructure;

namespace Tes3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountersOfCreatonsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CountersOfCreatonsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CountersOfCreatons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountersOfCreaton>>> GetCountersOfCreatons()
        {
          if (_context.CountersOfCreatons == null)
          {
              return NotFound();
          }
            return await _context.CountersOfCreatons.ToListAsync();
        }

        // GET: api/CountersOfCreatons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountersOfCreaton>> GetCountersOfCreaton(int id)
        {
          if (_context.CountersOfCreatons == null)
          {
              return NotFound();
          }
            var countersOfCreaton = await _context.CountersOfCreatons.FindAsync(id);

            if (countersOfCreaton == null)
            {
                return NotFound();
            }

            return countersOfCreaton;
        }

        // PUT: api/CountersOfCreatons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountersOfCreaton(int id, CountersOfCreaton countersOfCreaton)
        {
            if (id != countersOfCreaton.Id)
            {
                return BadRequest();
            }

            _context.Entry(countersOfCreaton).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountersOfCreatonExists(id))
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

        // POST: api/CountersOfCreatons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CountersOfCreaton>> PostCountersOfCreaton(CountersOfCreaton countersOfCreaton)
        {
          if (_context.CountersOfCreatons == null)
          {
              return Problem("Entity set 'ApplicationContext.CountersOfCreatons'  is null.");
          }
            _context.CountersOfCreatons.Add(countersOfCreaton);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCountersOfCreaton", new { id = countersOfCreaton.Id }, countersOfCreaton);
        }

        // DELETE: api/CountersOfCreatons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountersOfCreaton(int id)
        {
            if (_context.CountersOfCreatons == null)
            {
                return NotFound();
            }
            var countersOfCreaton = await _context.CountersOfCreatons.FindAsync(id);
            if (countersOfCreaton == null)
            {
                return NotFound();
            }

            _context.CountersOfCreatons.Remove(countersOfCreaton);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CountersOfCreatonExists(int id)
        {
            return (_context.CountersOfCreatons?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
