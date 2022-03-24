using Microsoft.AspNetCore.SignalR;
using WebApplication1.Interface;

namespace WebApplication1
{
    public class Chat : Hub<IChatClient>
    {

        public async Task SendMessage(ChatMessage message)
        {
            await Clients.All.ReceiveMessage(message);
        }
    }
}
