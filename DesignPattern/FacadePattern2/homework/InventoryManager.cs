namespace FacadePattern2.homework;

public class InventoryManager
{
    private const int ItemStock = 100;
    public void Initialize()
    {
        Console.WriteLine("InventoryManager: 재고 시스템 연결... 초기 데이터 조회를 완료.");
    }

    public bool CheckStock(string item, int quantity)
    {
        Console.WriteLine($"InventoryManager: 상품 '{item}'의 {quantity}개 주문 확인(현재 재고: {ItemStock}개.");
        if (quantity <= ItemStock)
        {
            Console.WriteLine($"InventoryManager: 상품 '{item}'의 재고 확인 성공.");
            return true;
        }
        Console.WriteLine($"InventoryManager: [경고] 주문한 상품 {item}의 재고가 부족합니다.");
        return false;
    }
}