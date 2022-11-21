using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Swashbuckle.AspNetCore.SwaggerGen;
using weektestapi.Models;

namespace weektestapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        private readonly usercontext _dbContext;
        public loginController(usercontext dbContext)
        {
            _dbContext = dbContext;
        }

        /*public ActionResult loginuser()
        {
            login obj=new login();
            return ;
        }*/
        [HttpPost]
        public async Task<IActionResult> loginuser(string id,string pass,user user)
        {
            if (id != user.email && pass!=user.password)
            {
                return BadRequest();
            }
            var display = _dbContext.users.Where(m => m.email == id && m.password == pass).FirstOrDefault();

            //var user1 = await _dbContext.users.FindAsync(id);
              //var us = await _dbContext.users.FirstOrDefault(id);
            //var us=await _dbContext.users?.Any(e=>e.email==id)).GetValueOrDefault();
            //return (_dbContext.users?.Any(e => e.ID == id)).GetValueOrDefault();
            /*if (!userExists(id))
            {
                return NotFound();
            }
            else
            {
                //return NoContent();
                return CreatedAtAction(nameof(loginuser), new { id = user.ID }, user);
            }*/


            if (display == null)
            {
                return NotFound();
            }
            
            return CreatedAtAction(nameof(loginuser), new { id = user.email,pass=user.password}, display);
            
        }
        
    }
}
