using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tunify_Platform;
using Tunify_Platform.Data;

namespace Tunify_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly TunifyDBContext _context;

        public UserController(TunifyDBContext context)
        {
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModelUser>>> GetUsers()
        {
          if (_context.ModelUsers == null)
          {
              return NotFound();
          }
            return await _context.ModelUsers.ToListAsync();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ModelUser>> GetUser(int id)
        {
          if (_context.ModelUsers == null)
          {
              return NotFound();
          }
            var user = await _context.ModelUsers.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, ModelUser user)
        {
            if (id != user.ModelUserID)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ModelUser>> PostUser(ModelUser user)
        {
          if (_context.ModelUsers == null)
          {
              return Problem("Entity set 'TunifyDBContext.Users'  is null.");
          }
            _context.ModelUsers.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.ModelUserID }, user);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_context.ModelUsers == null)
            {
                return NotFound();
            }
            var user = await _context.ModelUsers.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.ModelUsers.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return (_context.ModelUsers?.Any(e => e.ModelUserID == id)).GetValueOrDefault();
        }
    }
}
