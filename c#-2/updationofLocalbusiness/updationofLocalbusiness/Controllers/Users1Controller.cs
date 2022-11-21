using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using updationofLocalbusiness.Models;

namespace updationofLocalbusiness.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Users1Controller : ControllerBase
    {
        private readonly CUSERSILAKKIYARDESKTOPTRAININGC2PROJECTLOCALBUSINESSPROJECTLOCALBUSINESSAPP_DATALOCALDBMDFContext _context;

        public Users1Controller(CUSERSILAKKIYARDESKTOPTRAININGC2PROJECTLOCALBUSINESSPROJECTLOCALBUSINESSAPP_DATALOCALDBMDFContext context)
        {
            _context = context;
        }

        // GET: api/Users1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users1>>> GetUsers1s()
        {
            return await _context.Users1s.ToListAsync();
        }

        // GET: api/Users1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users1>> GetUsers1(int id)
        {
            var users1 = await _context.Users1s.FindAsync(id);

            if (users1 == null)
            {
                return NotFound();
            }

            return users1;
        }

        // PUT: api/Users1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers1(int id, Users1 users1)
        {
            if (id != users1.Id)
            {
                return BadRequest();
            }

            _context.Entry(users1).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Users1Exists(id))
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

        // POST: api/Users1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Users1>> PostUsers1(Users1 users1)
        {
            _context.Users1s.Add(users1);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsers1", new { id = users1.Id }, users1);
        }

        // DELETE: api/Users1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsers1(int id)
        {
            var users1 = await _context.Users1s.FindAsync(id);
            if (users1 == null)
            {
                return NotFound();
            }

            _context.Users1s.Remove(users1);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Users1Exists(int id)
        {
            return _context.Users1s.Any(e => e.Id == id);
        }
    }
}
