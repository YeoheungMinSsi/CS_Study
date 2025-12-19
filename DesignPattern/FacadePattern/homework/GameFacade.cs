namespace FacadePattern.homework;

public class GameFacade
{
    private GraphicsEngine _graphics;
    private AudioMixer _audio;
    private NetworkManager _network;
    private DataLoader _dataLoader;
    private ChatManager _chatManager;
    private StatisticsManager _statisticsManager;
    private SettingsManager _settingsManager;
    
    public GameFacade()
    {
        this._graphics = new GraphicsEngine();
        this._audio = new AudioMixer();
        this._network = new NetworkManager();
        this._dataLoader = new DataLoader();
        this._chatManager = new ChatManager();
        this._statisticsManager = new StatisticsManager();
        this._settingsManager = new SettingsManager();
        Console.WriteLine("GemaFacade: 하위 시스템 준비 완료");
    }

    public void StartGame()
    {
        Console.WriteLine("\n---------GameFacade: 게임 시작 준비 -------");
        
        // 데이터 로드
        this._dataLoader.LoadAssets();
        this._dataLoader.LoadUserData(123);
        
        // 시스템 초기화(그래픽, 오디오)
        this._graphics.Initialize();
        this._audio.Initialize();
        
        // 설정 적용
        this._settingsManager.Initialize();
        this._settingsManager.ApplySettings();
        
        // 네트워크 연결
        this._network.Connect();
        this._chatManager.Initialize();

        // 마지막 실행
        this._graphics.RenderFrame("Loading...");
        this._audio.PlaySound("Loading Music...");
        
        Console.WriteLine("------GameFacade: 게임 시작 준비 완료 ---------");
        
        // 게임 종료 후
        Console.WriteLine("--------- GameFacade: 게임 종료 --------");
        this._statisticsManager.Initialize();
        this._statisticsManager.ReportGameResult(84);
    }
}