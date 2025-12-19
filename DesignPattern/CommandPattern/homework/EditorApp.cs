using System;
using System.Collections.Generic;

namespace CommandPattern.homework;

public class EditorApp
{
    private readonly Stack<ICommand> _history = new Stack<ICommand>();

    public void Execute(ICommand command)
    {
        // 명령 실행
        command.Execute();
        
        // 실행된 명령어 스택에 저장
        _history.Push(command);
    }

    public void Undo()
    {
        // 기록이 있는지 확인
        if (_history.Count > 0)
        {
            ICommand lastCommand = _history.Pop();
            // 해당 명령의 Undo 호출
            lastCommand.Undo();
        }
        else
        {
            Console.WriteLine("실행 취소할 이전 작업이 없습니다.");
        }
    }
}