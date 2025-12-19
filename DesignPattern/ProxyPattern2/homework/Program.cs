namespace ProxyPattern2.homework;

public class Program
{
    public static void Main(string[] agrs)
    {
        Console.WriteLine("-----------프로그램 시작----------\n");
        Console.WriteLine("App started.");

        IDatabase lazyDb = new LazyDatabaseProxy();
        
        lazyDb.Query("SELECT * FROM users");
        
        lazyDb.Query("SELECT * FROM posts");
    }
}