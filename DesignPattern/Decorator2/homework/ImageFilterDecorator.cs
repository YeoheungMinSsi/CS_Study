namespace Decorator2.homework;

public abstract class ImageFilterDecorator: IImageFilter
{
    protected IImageFilter _wrappedFilter;

    public ImageFilterDecorator(IImageFilter wrappedFilter)
    {
        _wrappedFilter = wrappedFilter;
    }

    public virtual string Apply(string image)
    {
        return _wrappedFilter.Apply(image);
    }
}