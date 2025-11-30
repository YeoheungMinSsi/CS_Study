using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AdapterPattern2.homework2;

public static class EnumLoggerFactory
{
    public static ILogger GetLogger(EnvironmentType? envType = null)
    {
        EnvironmentType currentEnv;
        if(envType.HasValue)
        {
            // 테스트: 외부에서 명시적으로 타입이 지정
            currentEnv = envType.Value;
        }
        else
        {
            // 일반: 환경변수 로드 - 기본적으로 DEV 설정
            string env = Environment.GetEnvironmentVariable("APP_ENV")?.ToLower() ?? "DEV";
            currentEnv = env switch
            {
                "PROD" => EnvironmentType.Production,
                "Local" => EnvironmentType.Local,
                _ => EnvironmentType.Development
            };
        }
        
        Console.WriteLine($"\n[FACTORY] CurrentENV : {currentEnv}");
        
        // Enum 값에 따른 적저랗ㄴ 어뎁터 생성 후 반환 (Switch 사용)
        return currentEnv switch
        {
            EnvironmentType.Production => new SentryAdapter(new SentryLogger()),
            EnvironmentType.Local => new FileAdapter(new FileLogger()),
            _ => new ConsoleAdapter(new ConsoleLogger())
        };

    }
}