namespace BridgePattern.homework;

public class Client
{
    public static void Main()
    {
        // ErrorLogger + ConsoleOutput
        Console.WriteLine("----- 에러 로그를 콘솔에 출력 -----");
        Logger consoleErrorLogger = new ErrorLogger(new ConsoleOutput());
        consoleErrorLogger.Log("데이터베이스 연결 실패");
        
        // ErrorLogger + FileOutput
        Console.WriteLine("----- 에러 로그를 파일에 저장 -----");
        Logger fileErrorLogger = new ErrorLogger(new FileOutput());
        fileErrorLogger.Log("데이터베이스 SELETE 실패");
        
        // InfoLogger + ConsoleOutput
        Console.WriteLine("------ 정보 로그를 콘솔에 출력 -------");
        Logger consoleInfoLogger = new InfoLogger(new ConsoleOutput());
        consoleInfoLogger.Log("새로운 설정 값 로드 완료");
        
        // InfoLogger + fileOutput
        Console.WriteLine("---- 정보 로그를 파일에 저장 -------");
        Logger fileInfoLogger = new InfoLogger(new FileOutput());
        fileInfoLogger.Log("사용자 로그인 성공");
    
        // WarnLogger + NetworkOuput
        Console.WriteLine("------- 네크워크 연결 경고 -------");
        Logger networkWarnLogger = new WarnLogger(new NetworkOutput());
        networkWarnLogger.Log("HTTPS 연결 오류가 발생");
        networkWarnLogger.OutputImple = new FileOutput();  // 내구 구현체 변경
        networkWarnLogger.Log("오류 내용을 저장하겠습니다.");
        
        // DebugLogger + SlackOutput
        Console.WriteLine("------ 디버깅 로그를 슬랙에 추가 ------");
        Logger slackDebugLogger = new DebugLogger(new SlackOutput());
        slackDebugLogger.Log("디버깅이 완료되었습니다.");
    }
}