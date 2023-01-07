using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LearnNet6.Data;
using LearnNet6.Data.Entity;

namespace LearnNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageTypesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MessageTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MessageTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MessageType>>> GetMessageType()
        {
            return await _context.MessageType.ToListAsync();
        }

        // GET: api/MessageTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MessageType>> GetMessageType(int id)
        {
            var messageType = await _context.MessageType.FindAsync(id);

            if (messageType == null)
            {
                return NotFound();
            }

            return messageType;
        }

        // PUT: api/MessageTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessageType(int id, MessageType messageType)
        {
            if (id != messageType.Id)
            {
                return BadRequest();
            }

            _context.Entry(messageType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessageTypeExists(id))
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

        // POST: api/MessageTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MessageType>> PostMessageType(MessageType messageType)
        {
            _context.MessageType.Add(messageType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessageType", new { id = messageType.Id }, messageType);
        }

        // DELETE: api/MessageTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessageType(int id)
        {
            var messageType = await _context.MessageType.FindAsync(id);
            if (messageType == null)
            {
                return NotFound();
            }

            _context.MessageType.Remove(messageType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MessageTypeExists(int id)
        {
            return _context.MessageType.Any(e => e.Id == id);
        }
    }
}
