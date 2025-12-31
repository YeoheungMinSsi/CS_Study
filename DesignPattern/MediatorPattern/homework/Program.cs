namespace MediatorPattern.homework;

public class Program
{
    public static void Main(string[] args)
    {
        var chatRoom = new ChatRoom();
        var user1 = new User("Kimchi", chatRoom);
        var user2 = new User("Parkchi", chatRoom);
        var user3 = new User("Leechi", chatRoom);
        
        chatRoom.AddUser(user1);
        chatRoom.AddUser(user2);
        chatRoom.AddUser(user3);

        user1.Send("반갑씁니다.");
    }
}