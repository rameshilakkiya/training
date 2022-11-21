using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using weektestapi.Models;

namespace weektestapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly usercontext _dbContext;
        public userController(usercontext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<user>>> Getuser()
        {
            if (_dbContext.users == null)
            {
                return NotFound();
            }
            return await _dbContext.users.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<user>> Getuser(int id)
        {
            if (_dbContext.users == null)
            {
                return NotFound();
            }
            var user = await _dbContext.users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
        [HttpPost]
        public async Task<ActionResult<user>> Postuser(user user)
        {
            _dbContext.users.Add(user);
            await _dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(Getuser), new { id = user.ID }, user);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Putuser(int id, user user)
        {
            if (id != user.ID)
            {
                return BadRequest();
            }

            _dbContext.Entry(user).State = EntityState.Modified;

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
            if (_dbContext.users == null)
            {
                return NotFound();
            }

            var user = await _dbContext.users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _dbContext.users.Remove(user);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool userExists(long id)
        {
            return (_dbContext.users?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
