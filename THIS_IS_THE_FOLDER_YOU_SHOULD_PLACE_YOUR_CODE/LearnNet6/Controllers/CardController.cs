using FirebaseAdmin.Messaging;
using LearnNet6.Data;
using LearnNet6.Data.Entity;
using LearnNet6.SignalR;
using LearnNet6.Utilities;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace LearnNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IHubContext<SignalRHub, IChatClient> _hubContext;

        public CardController(IHubContext<SignalRHub, IChatClient> hubContext, ApplicationDbContext context)
        {
            _hubContext = hubContext;
            _context = context;
        }

        // GET: api/Card
        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public async Task<ActionResult<IEnumerable<Card>>> GetCards()
        {
            return await _context.Cards.ToListAsync();
        }

        // GET: api/Card/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Card>> GetCard(Guid id)
        {
            var card = await _context.Cards.FindAsync(id);

            if (card == null)
            {
                return NotFound();
            }

            return card;
        }

        // PUT: api/Card/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCard(Guid id, Card card)
        {
            if (id != card.Id)
            {
                return BadRequest();
            }

            _context.Entry(card).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                await _hubContext.Clients.All.UpdateCard(card);

                var accessToken = Request.HttpContext.Request.Headers["Authorization"].ToString().Split(' ')[1];
                var userId = JwtHelpers.DecodeJwt(accessToken);
                var currentUser = await _context.AdUsers.FirstOrDefaultAsync(x => x.id == userId);
                if (currentUser !=null)
                {
                    var notificationToken = _context.NotificationToken.Where(x => x.UserId == currentUser.Id);
                    foreach (var token in notificationToken)
                    {
                        Message mes = new Message()
                        {
                            Token = token.Value,

                            Data = new Dictionary<string, string>()
                            {
                                {"notification","Có thằng mới chỉnh data" }
                            },
                            Notification = new Notification()
                            {
                                Title = "Quản trị viên CoStudy",
                                Body = "Có thằng mới chỉnh data"
                            }
                        };
                        string response = await FirebaseMessaging.DefaultInstance.SendAsync(mes).ConfigureAwait(true);
                    }
                   
                }
                
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardExists(id))
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

        // POST: api/Card
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Card>> PostCard(Card card)
        {
            card.Id = Guid.NewGuid();
            _context.Cards.Add(card);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCard", new { id = card.Id }, card);
        }

        // DELETE: api/Card/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCard(Guid id)
        {
            var card = await _context.Cards.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }

            _context.Cards.Remove(card);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CardExists(Guid id)
        {
            return _context.Cards.Any(e => e.Id == id);
        }

        [HttpPost("update-all-card")]
        public async Task<IActionResult> UpdateAllCard(List<Card> cards)
        {
            foreach (var item in cards)
            {
                _context.Cards.Update(item);
                await _context.SaveChangesAsync();
            }
            await _hubContext.Clients.All.UpdateCardBoard(cards);

            var accessToken = Request.HttpContext.Request.Headers["Authorization"].ToString().Split(' ')[1];
            var userId = JwtHelpers.DecodeJwt(accessToken);
            var currentUser = await _context.AdUsers.FirstOrDefaultAsync(x => x.id == userId);
            if (currentUser != null)
            {
                var notificationToken = _context.NotificationToken.Where(x => x.UserId == currentUser.Id);
                foreach (var token in notificationToken)
                {
                    Message mes = new Message()
                    {
                        Token = token.Value,

                        Data = new Dictionary<string, string>()
                            {
                                {"notification","Có thằng mới chỉnh data" }
                            },
                        Notification = new Notification()
                        {
                            Title = "Tét nofitication",
                            Body = "Có thằng mới chỉnh data"
                        }
                    };
                    string response = await FirebaseMessaging.DefaultInstance.SendAsync(mes).ConfigureAwait(true);
                }

            }
            return Ok(cards);
        }
    }
}
