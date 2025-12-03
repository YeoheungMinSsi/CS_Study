namespace Decorator.homework;

public class UnderlineDecorator: TextDecorator
{
    // private const string HtmlUnderlineOpenTag = "<u>";
    // private const string HtmlUnderlineCloseTag = "</u>";
    // private const string MarkdownUnderlineTag = "__";
    //
    // public UnderlineDecorator(IText text, IFormatStrategy strategy): base(text, strategy){ }
    //
    // public override string Render()
    // {
    //     string openTag;
    //     string closeTag;
    //     if (_strategy is HtmlStrategy)
    //     {
    //         openTag = HtmlUnderlineOpenTag;
    //         closeTag = HtmlUnderlineCloseTag;
    //     }
    //     else
    //     {
    //         openTag = MarkdownUnderlineTag;
    //         closeTag = MarkdownUnderlineTag;
    //     }
    //     
    //     return _strategy.Format(_text.Render(), openTag, closeTag);
    // }
    
    public UnderlineDecorator(IText text): base(text){ }
    
    public override string RenderHtml()
    {
        return $"<u>{_text.RenderHtml()}</u>";
    }
    public override string RenderMarkdown()
    {
        return $"__{_text.RenderMarkdown()}__";
    }
}