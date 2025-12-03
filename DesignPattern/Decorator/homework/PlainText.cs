namespace Decorator.homework;

public class PlainText: IText
{
    private readonly string _text;

    public PlainText(string text)
    {
        this._text = text;
    }

    // public string Render()
    // {
    //     return this._text;
    // }

    public string RenderHtml()
    {
        return this._text;
    }
    
    public string RenderMarkdown()
    {
        return this._text;
    }
}