namespace Decorator.homework;

public abstract class TextDecorator : IText
{
    protected readonly IText _text;
    // protected readonly IFormatStrategy _strategy;
    
    // public TextDecorator(IText text, IFormatStrategy strategy)
    // {
    //     this._text = text;
    //     this._strategy = strategy;
    // }
    public TextDecorator(IText text)
    {
        this._text = text;
    }
    
    // 구현하는 데코레이터는 이 메서드를 오버라이드 해서 새로운 기능 추가 - 강제성
    // public virtual string Render()
    // {
    //     return _text.HtmlRender();
    // }
    
    public abstract string RenderHtml();
    public abstract string RenderMarkdown();
}