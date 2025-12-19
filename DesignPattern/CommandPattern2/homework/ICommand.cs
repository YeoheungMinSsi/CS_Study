namespace CommandPattern2.homework;

public interface ICommand
{
    void Execute();
    string Name { get; }
}