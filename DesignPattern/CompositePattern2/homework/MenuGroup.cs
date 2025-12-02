using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;

namespace CompositePattern2.homework;

public class MenuGroup: IMenuComponent
{
    private readonly string _name;
    private readonly List<IMenuComponent> _menuComponents = new List<IMenuComponent>();
    private List<string> _tags = new List<string>();

    public MenuGroup(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("그룹 이름이 들어가야합니다.");
        this._name = name;
    }
    
    public void Add(IMenuComponent menuComponent)
    {
        this._menuComponents.Add(menuComponent);
    }

    public void Remove(IMenuComponent menuComponent)
    {
        _menuComponents.Remove(menuComponent);
    }

    public void Display(int indent)
    {
        string indentation = new string(' ', indent*2);
        
        Console.WriteLine($"{indentation}|- {this._name}");
        foreach (var menuComponent in _menuComponents)
        {
            menuComponent.Display(indent+1);
        }
    }
    
    List<IMenuComponent> FindByTag(string tag)
    {
        var foundComponents = new List<IMenuComponent>();
            
        // 1. 현재 노드 검사
        if (ContainsTag(tag))
        {
            foundComponents.Add(this);
        }
            
        // 2. 자식 노드 재귀 탐색 및 결과 통합
        foreach (var component in this._menuComponents)
        {
            foundComponents.AddRange(component.FindByTag(tag));
        }
            
        return foundComponents;
    }
}