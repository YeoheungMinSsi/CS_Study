namespace CompositePattern2.homework;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--- 복합체 패턴을 이용한 메뉴 구조 출력 ---");
        
        // 1. 최상위 메뉴 그룹 생성 (Root Node)
        // indent = 0에서 시작
        var mainMenu = new MenuGroup("메뉴");

        // 2. 단일 항목 (Leaf) 추가
        mainMenu.Add(new MenuItem("홈"));
        mainMenu.Add(new MenuItem("소개"));

        // 3. '제품' 그룹 생성 (1단계 깊이)
        var productGroup = new MenuGroup("제품");
        
        // 4. '전자제품' 그룹 생성 (2단계 깊이)
        var electronicsGroup = new MenuGroup("전자제품");
        electronicsGroup.Add(new MenuItem("TV"));
        electronicsGroup.Add(new MenuItem("냉장고"));
        
        // 5. '가전제품' 그룹 생성 (2단계 깊이)
        var appliancesGroup = new MenuGroup("가전제품");
        // appliancesGroup.Add(new MenuItem("세탁기")); // 예시를 위해 항목 추가 가능

        // 6. 구조 조립: '제품' 그룹에 하위 그룹들을 추가
        productGroup.Add(electronicsGroup);
        productGroup.Add(appliancesGroup);

        // 7. 최상위 '메뉴' 그룹에 '제품' 그룹 추가
        mainMenu.Add(productGroup);

        // --- 출력 ---
        // 최상위 노드에 대해 Display(0) 호출
        mainMenu.Display(0);
    }
}