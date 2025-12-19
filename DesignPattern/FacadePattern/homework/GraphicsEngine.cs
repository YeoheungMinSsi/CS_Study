namespace FacadePattern.homework;

public class GraphicsEngine
{
    public void Initialize()
    {
        Console.WriteLine("GraphicEngine: 그래픽 시스템 초기화 시작");
    }

    public void RenderFrame(string scene)
    {
        Console.WriteLine($"GraphicEngine: {scene} 렌더링 시작");
    }
}