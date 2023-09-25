using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreMVC_Exam.Data;
using CoreMVC_Exam.Models;

namespace CoreMVC_Exam.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserClientsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public UserClientsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/UserClients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserClient>>> GetUsersClients()
        {
          if (_context.UsersClients == null)
          {
              return NotFound();
          }
            return await _context.UsersClients.ToListAsync();
        }

        // GET: api/UserClients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserClient>> GetUserClient(int id)
        {
          if (_context.UsersClients == null)
          {
              return NotFound();
          }
            var userClient = await _context.UsersClients.FindAsync(id);

            if (userClient == null)
            {
                return NotFound();
            }

            return userClient;
        }

        // PUT: api/UserClients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserClient(int id, UserClient userClient)
        {
            if (id != userClient.id)
            {
                return BadRequest();
            }

            _context.Entry(userClient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserClientExists(id))
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

        // POST: api/UserClients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserClient>> PostUserClient(UserClient userClient)
        {
          if (_context.UsersClients == null)
          {
              return Problem("Entity set 'ApplicationContext.UsersClients'  is null.");
          }
            _context.UsersClients.Add(userClient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserClient", new { id = userClient.id }, userClient);
        }

        // DELETE: api/UserClients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserClient(int id)
        {
            if (_context.UsersClients == null)
            {
                return NotFound();
            }
            var userClient = await _context.UsersClients.FindAsync(id);
            if (userClient == null)
            {
                return NotFound();
            }

            _context.UsersClients.Remove(userClient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserClientExists(int id)
        {
            return (_context.UsersClients?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
