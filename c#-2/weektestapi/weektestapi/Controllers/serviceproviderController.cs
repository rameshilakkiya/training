using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using weektestapi.Models;

namespace weektestapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class serviceproviderController : ControllerBase
    {
        private readonly usercontext _dbContext;
        public serviceproviderController(usercontext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<serviceprovider>>> Getuser()
        {
            if (_dbContext.serviceproviders == null)
            {
                return NotFound();
            }
            return await _dbContext.serviceproviders.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<serviceprovider>> Getuser(int id)
        {
            if (_dbContext.serviceproviders == null)
            {
                return NotFound();
            }
            var serviceprovider = await _dbContext.serviceproviders.FindAsync(id);

            if (serviceprovider == null)
            {
                return NotFound();
            }

            return serviceprovider;
        }

        [HttpPost]
        public async Task<ActionResult<serviceprovider>> Postuser(serviceprovider serviceprovider)
        {
            _dbContext.serviceproviders.Add(serviceprovider);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(Getuser), new { id = serviceprovider.ID }, serviceprovider);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Putuser(int id, serviceprovider serviceprovider)
        {
            if (id != serviceprovider.ID)
            {
                return BadRequest();
            }

            _dbContext.Entry(serviceprovider).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!userExists(id))
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
        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteuser(int id)
        {
            if (_dbContext.serviceproviders == null)
            {
                return NotFound();
            }

            var serviceprovider = await _dbContext.serviceproviders.FindAsync(id);
            if (serviceprovider == null)
            {
                return NotFound();
            }

            _dbContext.serviceproviders.Remove(serviceprovider);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool userExists(long id)
        {
            return (_dbContext.serviceproviders?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
