using LearnNet6.Data.Entity;
using Microsoft.AspNetCore.SignalR;

namespace LearnNet6.SignalR
{
    public class SignalRHub : Hub
    {
        Task JoinGroup(string groupName)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }

        public async Task SendCardBoard(string message)
        {
            await Clients.All.SendAsync("ReceiveCardBoard", message);
        }
        Task UpdateCard(Card card)
        {
            return Clients.All.SendAsync("UpdateCard", card);
        }
    }
}
