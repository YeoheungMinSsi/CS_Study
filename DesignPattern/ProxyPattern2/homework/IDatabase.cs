namespace ProxyPattern2.homework;

public interface IDatabase
{
    void Connect();
    void Query(string sql);
    void Disconnect();
}