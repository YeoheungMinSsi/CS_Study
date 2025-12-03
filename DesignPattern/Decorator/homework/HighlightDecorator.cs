namespace Decorator.homework;

public class HighlightDecorator: TextDecorator
{
    // private const string HtmlHighlightOpenTag = "<mark>";
    // private const string HtmlHighlightCloseTag = "</mark>";
    // private const string MarkdownHighlightTag = "===";
    //
    // public HighlightDecorator(IText text, IFormatStrategy strategy): base(text, strategy){ }
    //
    // public override string Render()
    // {
    //     string openTag;
    //     string closeTag;
    //     if (_strategy is HtmlStrategy)
    //     {
    //         openTag = HtmlHighlightOpenTag;
    //         closeTag = HtmlHighlightCloseTag;
    //     }
    //     else
    //     {
    //         openTag = MarkdownHighlightTag;
    //         closeTag = MarkdownHighlightTag;
    //     }
    //     
    //     return _strategy.Format(_text.Render(), openTag, closeTag);
    // }
    
    public HighlightDecorator(IText text): base(text){ }

    public override string RenderHtml()
    {
        return $"<mark>{_text.RenderHtml()}</mark>";
    }
    public override string RenderMarkdown()
    {
        return $"==={_text.RenderMarkdown()}===";
    }
}