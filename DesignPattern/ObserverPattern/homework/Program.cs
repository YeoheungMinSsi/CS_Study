namespace ObserverPattern.homework;

public class Program
{
    public static void Main(string[] args)
    {
        // 뉴스주제(Subject) 생성
        // var newsAgency = new NewsAgency(); - 프로퍼티 미 입력 전
        var sportsAgency = new NewsAgency("스포츠");
        var techAgency = new NewsAgency("IT/Tech");
        
        // 구독자 생성
        var emailSub = new EmailSubscriber();
        var appSub = new AppSubscriber();
        var analyticsSub = new AnalyticsSubscriber();
        
        // 필터형 구독자 생성 - it 단일 필터
        // var filterAgency = new FilterAgency(NewsCategory.It);
        // 다수 필터 구독자 생성 - IT와 문화 필터
        var filterAgency = new FilterAgency(NewsCategory.It | NewsCategory.SportsDomestic);
        
        // 구독자 추가(등록) - 이전 코드
        // newsAgency.AddObserver(emailSub);
        // newsAgency.AddObserver(appSub);
        // newsAgency.AddObserver(analyticsSub);
        
        // 스포츠에이전시, 테크에이전시 둘다 등록
        sportsAgency.AddObserver(filterAgency);
        techAgency.AddObserver(filterAgency);

        // 뉴스 발행 - 1
        News news1 = new News("[React] 리엑트 보안 취약점 발견!", NewsCategory.It, "리엑트의 보안 취약점이 발견되었습니다.");
        // newsAgency.Publish(news1);  // 이전코드
        techAgency.Publish(news1);
        
        // 뉴스 발생 - 2 / 구독자 제거 후 수행
        // newsAgency.RemoveObserver(appSub); // 이전코드
        News news2 = new News("[울산FC] 세징야 이적!?", NewsCategory.SportsDomestic, "현재 대구 감독과의 불화를 언급한 세징야가 이적설에 휘말렸다.");
        // newsAgency.Publish(news2);  // 이전코드
        sportsAgency.Publish(news2);  // 구독 카테고리를 IT와 국내 스포츠만 수행하여 다른 카테고리를 입력하면 Update가 일어나지 않음
        
        
    
    }
}