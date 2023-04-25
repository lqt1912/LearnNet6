using LearnNet6.Data.Entity;
using LearnNet6.Models.Requests;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace LearnNet6.SignalR
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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

        public async Task UpdateBoard(UpdateBoardRequest[] cards)
        {
            await Clients.All.SendAsync("UpdateBoardFromServer", cards);
        }
    }
}
