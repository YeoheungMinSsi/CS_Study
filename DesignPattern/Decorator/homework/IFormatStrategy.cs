namespace Decorator.homework;

public interface IFormatStrategy
{
    // note: 텍스트를 감싸는 메서드, prefix와 suffix만 제공
    string Format(string text, string prefix, string suffix);
}