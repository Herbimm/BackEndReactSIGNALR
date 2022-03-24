using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.Interface;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly IHubContext<Chat, IChatClient> _chatHub;

        public ChatController(IHubContext<Chat, IChatClient> chatHub)
        {
            _chatHub = chatHub;
        }

        [HttpPost("messages")]
        public async Task Post(ChatMessage message)
        {
            // run some logic...

            await _chatHub.Clients.All.ReceiveMessage(message);
        }
    }
}