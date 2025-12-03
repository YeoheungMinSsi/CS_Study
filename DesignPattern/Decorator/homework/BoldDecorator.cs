namespace Decorator.homework;

public class BoldDecorator: TextDecorator
{
    // private const string HtmlBoldOpenTag = "<b>";
    // private const string HtmlBoldCloseTag = "</b>";
    // private const string MarkdownBoldTag = "**";
    
    // public BoldDecorator(IText text, IFormatStrategy strategy): base(text, strategy){ }

    // public override string Render()
    // {
    //     string openTag;
    //     string closeTag;
    //
    //     if (_strategy is HtmlStrategy)
    //     {
    //         openTag = HtmlBoldOpenTag;
    //         closeTag = HtmlBoldCloseTag;
    //     }
    //     else
    //     {
    //         openTag = MarkdownBoldTag;
    //         closeTag = MarkdownBoldTag;
    //     }
    //
    //     return _strategy.Format(_text.Render(), openTag, closeTag);
    // }
    
    public BoldDecorator(IText text): base(text){ }
    
    public override string RenderHtml()
    {
        return $"<b>{_text.RenderHtml()}</b>";
    }
    public override string RenderMarkdown()
    {
        return $"**{_text.RenderMarkdown()}**";
    }
}