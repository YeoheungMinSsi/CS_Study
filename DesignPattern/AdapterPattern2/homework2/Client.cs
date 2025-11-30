namespace AdapterPattern2.homework2;

public class Client
{
    public static void Main(string[] args)
    {
        Console.WriteLine("------- 로깅 / 어뎁터 테스트 시작(Enum 기반) ------");
        ILogger devLogger = EnumLoggerFactory.GetLogger(EnvironmentType.Development);
        devLogger.Log("DEV: 디버깅 정보 출력");
        Console.WriteLine("------- [ConsoleAdapter] 테스트 완료 ---------");
        
        ILogger fileLogger = EnumLoggerFactory.GetLogger(EnvironmentType.Local);
        fileLogger.Log("Local: 설정 값 변경");
        Console.WriteLine("------- [FileAdapter] 테스트 완료 ---------");
        
        ILogger sentryLogger = EnumLoggerFactory.GetLogger(EnvironmentType.Production);
        sentryLogger.Log("PROD: 오류발생");
        Console.WriteLine("------- [SentryAdapter] 테스트 완료 ---------");
        
        Console.WriteLine("=== 4. 일반 환경 변수 기반 테스트 ===");
        ILogger normalLogger = EnumLoggerFactory.GetLogger();
        normalLogger.Log("일반: 현재 설정된 환경에 따른 로그");
        
    }
}