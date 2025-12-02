namespace CompositePattern.homework;

public class Program
{
    public static void Main()
    {
        // 태그 값
        var divNode = new ElementNode("div");
        var pNode = new ElementNode("p");
        var spanNode = new ElementNode("span");
        
        // 텍스트
        var helloText = new TextNode("Hello");
        var worldText = new TextNode("World");
        
        // 연결
        spanNode.AddChild(worldText);
        // p 노드의 자식
        pNode.AddChild(helloText);
        pNode.AddChild(spanNode);
        
        divNode.AddChild(pNode);
        // div - p - hello - span - world 
        string finalHtml = divNode.Render();
        Console.WriteLine(finalHtml);

    }
}