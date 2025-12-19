namespace ChainResponsibility.homework;

public class Request
{
    public User? User { get; set; }
    public object? Body { get; set; }
    public Dictionary<string, string>? Headers { get; set; }
}

public class User
{
    public string Name { get; set; }
    public string Role { get; set; }
}