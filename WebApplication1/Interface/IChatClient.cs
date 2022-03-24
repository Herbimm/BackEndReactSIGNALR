namespace WebApplication1.Interface
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
