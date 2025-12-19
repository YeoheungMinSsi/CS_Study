namespace Decorator2.homework;

public class BaseImage : IImageFilter
{
    private readonly string _image;

    public BaseImage(string image)
    {
        _image = image;
    }
    
    public string Apply(string image)
    { 
        return _image;
    }
}