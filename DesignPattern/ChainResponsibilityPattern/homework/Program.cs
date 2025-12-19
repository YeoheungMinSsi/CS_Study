namespace ChainResponsibility.homework;

public class Program
{
    public static void Main(string[] args)
    {
        var logging = new LoggingHandler();
        var auth = new AuthHandler();
        var validation = new ValidationHandler();
        var controller = new ControllerHandler();

        logging.SetNext(auth).SetNext(validation).SetNext(controller);
        // logging.SetNext(auth).SetNext(controller).SetNext(validation);

        var testRequest = new Request
        {
            User = new User { Name = "Loki", Role = "User" },
            Body = new { Message = "Hi" }
        };
        
        logging.Handle(testRequest);
    
    }
}