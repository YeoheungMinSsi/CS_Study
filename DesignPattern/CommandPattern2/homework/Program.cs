namespace CommandPattern2.homework;

public class Program
{
    public static void Main(string[] args)
    {
        Receiver appLogin = new Receiver();

        Button openButton = new Button(new OpenCommand(appLogin));
        Button saveButton = new Button(new SaveCommand(appLogin));
        Button exitButton = new Button(new ExitCommand(appLogin));
        
        
        openButton.Click();
        saveButton.Click();
        exitButton.Click();
    
    }
}