namespace ObserverPattern.homework;

public interface IObserver
{
    // agency는 어디서 전송했는지 아려주는 부분 추가하는 부분(동아신문 같은 부분)
    // 추후 추가시 사용
    // void Update(News news, string agencyName);
    void Update(News news);
}