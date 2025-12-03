namespace Decorator.homework;

public class ItalicDecorator: TextDecorator
{
    // private const string HtmlItalicOpenTag = "<i>";
    // private const string HtmlItalicCloseTag = "</i>";
    // private const string MarkdownItalicTag = "_";
    // public ItalicDecorator(IText text, IFormatStrategy strategy): base(text, strategy){ }
    //
    // public override string Render()
    // {
    //     string openTag;
    //     string closeTag;
    //     if (_strategy is HtmlStrategy)
    //     {
    //         openTag = HtmlItalicOpenTag;
    //         closeTag = HtmlItalicCloseTag;
    //     }
    //     else
    //     {
    //         openTag = MarkdownItalicTag;
    //         closeTag = MarkdownItalicTag;
    //     }
    //     
    //     return _strategy.Format(_text.Render(), openTag, closeTag);
    // }
    
    public ItalicDecorator(IText text): base(text){ }
    
    public override string RenderHtml()
    {
        return $"<i>{_text.RenderHtml()}</i>";
    }
    public override string RenderMarkdown()
    {
        return $"_{_text.RenderMarkdown()}_";
    }
}