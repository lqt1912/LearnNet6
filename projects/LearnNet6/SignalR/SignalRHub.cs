using LearnNet6.Data.Entity;
using Microsoft.AspNetCore.SignalR;

namespace LearnNet6.SignalR
{
    public class SignalRHub : Hub
    {
        public async Task JoinGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task SendCardBoard(string message)
        {
            await Clients.All.SendAsync("ReceiveCardBoard", message);
        }

        public async Task SendMessageGroup(string groupName, string message)
        {
            await Clients.Group(groupName).SendAsync("ReceiveMessageGroup",message);
        }
        public async Task UpdateCard(Card card)
        {
            await Clients.All.SendAsync("UpdateCard", card);
        }

        public async Task UpdateBoard(Card[] cards)
        {
            await Clients.All.SendAsync("UpdateBoardFromServer", cards);
        }
    }
}
