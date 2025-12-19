namespace ProxyPattern2.homework;

public class RealDatabase: IDatabase
{
    public void Connect()
    {
        Console.WriteLine("[RealDatabase]Connecting to database...");
    }

    public void Query(string sql)
    {
        Console.WriteLine($"[RealDatabase]Executing SQL: {sql}");
    }

    public void Disconnect()
    {
        Console.WriteLine("[RealDatabase]Disconnected from database...");
    }
}