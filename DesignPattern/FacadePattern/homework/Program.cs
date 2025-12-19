namespace FacadePattern.homework;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("클라이언트: GameFacade 객체 생성");
        
        // Facede 객체 생성
        GameFacade gameFacade = new GameFacade();
        
        Console.WriteLine("\n클라이언트: 단일 메서드 호출로 게임 시작");
        
        gameFacade.StartGame();
    }
}