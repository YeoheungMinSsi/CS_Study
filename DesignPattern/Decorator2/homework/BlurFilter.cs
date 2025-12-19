namespace Decorator2.homework;

public class BlurFilter: ImageFilterDecorator
{
    public BlurFilter(IImageFilter wrappedFilter) : base(wrappedFilter) { }

    public override string Apply(string image)
    {
        string processedImage = base.Apply(image);

        Console.WriteLine($"[Filter] 블러(Blur) 효과 적용. (입력: {processedImage})");
        return $"Blur({processedImage})";
    }
}