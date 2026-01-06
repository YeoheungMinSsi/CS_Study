namespace MementoPattern2.homework;

public record Position(double X, double Y );
public record Size(double Width, double Height);

public record DesignElement(
    string Id,
    Position Position,
    Size Size,
    string Color
    )
    

{
    public override string ToString() => 
        $"{Id}-[위치:({Position.X}, {Position.Y}), 크기:{Size.Width}x{Size.Height}, 색상:{Color}]";
}
