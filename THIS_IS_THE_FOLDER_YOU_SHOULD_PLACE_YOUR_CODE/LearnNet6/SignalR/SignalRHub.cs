using LearnNet6.Data.Entity;
using Microsoft.AspNetCore.SignalR;

namespace LearnNet6.SignalR
{
    public interface IChatClient
    {
        Task UpdateCardBoard(List<Card> cards);
        Task UpdateCard(Card card);
    }
    public class SignalRHub : Hub<IChatClient>
    {

    }
}
