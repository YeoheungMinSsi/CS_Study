namespace FacadePattern.homework;

public class DataLoader
{
    public void LoadAssets()
    {
        Console.WriteLine("DataLoader: 필수 게임 에셋 로딩 완료(텍스처, 모델)");
    }

    public void LoadUserData(int userId)
    {
        Console.WriteLine($"DataLoader: 사용자 ID {userId}의 데이터 로딩 완료");
    }
}