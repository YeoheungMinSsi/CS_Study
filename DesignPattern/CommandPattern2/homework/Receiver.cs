namespace CommandPattern2.homework;

public class Receiver
{
    public void Save()
    {
        Console.WriteLine("[AppLogic] File saved successfully");
    }

    public void Open()
    {
        Console.WriteLine("[AppLogic] File opened successfully");
    }

    public void Exit()
    {
        Console.WriteLine("[AppLogic] Exiting application");
    }
}