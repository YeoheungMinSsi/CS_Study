namespace CommandPattern.homework;

public interface ICommand
{
    void Execute();
    void Undo();
}