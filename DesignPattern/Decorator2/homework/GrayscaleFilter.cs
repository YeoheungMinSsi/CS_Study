namespace Decorator2.homework;

public class GrayscaleFilter: ImageFilterDecorator
{
    public GrayscaleFilter(IImageFilter wrappedFilter) : base(wrappedFilter) { }

    public override string Apply(string image)
    {
        string processedImage = base.Apply(image);

        Console.WriteLine($"[Filter] 흑백(Grayscale) 효과 적용. (입력: {processedImage})");
        return $"Grayscale({processedImage})";
    }
}