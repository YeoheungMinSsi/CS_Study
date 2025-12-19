namespace ProxyPattern2.homework;

public class LazyDatabaseProxy:IDatabase
{
    // RealDatabase를 참조하는 필드 null을 통해서 생성 즉시 생성하지 않음
    private IDatabase _realDatabase = null;

    public LazyDatabaseProxy()
    {
        Console.WriteLine("[Proxy] Delaying DB connection until needed...");
    }
    
    public void Connect()
    {
        if (_realDatabase != null)  // 연결되어 있다면
        {
            Console.WriteLine("[Proxy] Database is already connected via Query call");
        }
        else  // 연결되어 있지 않다면
        {
            Console.WriteLine("[Proxy] Connect requested, but actual connection is deferred.");
        }
    }

    public void Query(string sql)
    {
        if (_realDatabase == null)
        {
            Console.WriteLine("[Proxy] Establishing connection now...");  // 설정 연결중
            
            // 실제 객체를 생성하고 연결
            _realDatabase = new RealDatabase();
            _realDatabase.Connect();
        }
        _realDatabase.Query(sql);  // 작업 위임
    }

    public void Disconnect()
    {
        if (_realDatabase != null)  // 연결 된 상태라면
        {
            Console.WriteLine("[Proxy] Disconnecting RealDatabase.");
            _realDatabase.Disconnect();
            _realDatabase = null;
        }
        else  // 연결되어 있지 않은 상태라면
        {
            Console.WriteLine("[Proxy] No Connection to disconnect.");
        }
    }
}
