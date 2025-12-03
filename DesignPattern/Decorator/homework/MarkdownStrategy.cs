namespace Decorator.homework;

public class MarkdownStrategy: IFormatStrategy
{
    public string Format(string text, string prefix, string suffix)
    {
        return $"{prefix}{text}{suffix}";
    }
}