namespace ChainResponsibilityPattern2.homework;

public interface ISpamFilter
{
    ISpamFilter SetNext(ISpamFilter spamFilter);
    bool Check(string message);
}