namespace MediatorPattern.homework;

public class ChatRoom: IChatMediator
{
    private List<User> _users = new List<User>();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users)
        {
            if (user != sender)  // 받는사람 : user, 전송하는 주체: sender
            {
                Console.WriteLine($"[ChatRoom] {sender.Name} -> {user.Name}: {message}");
                user.Receive(message, sender.Name);
            }
        }
    }
}