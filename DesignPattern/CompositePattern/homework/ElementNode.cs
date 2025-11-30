using System;
using System.Text;
using System.Collections.Generic;

namespace CompositePattern.homework;

public class ElementNode: INode
{
    // 태그 이름을 지정하는 필드
    private readonly string _tagName;

    // 속성 관리
    protected readonly Dictionary<string, string> _attributes = new Dictionary<string, string>();
    
    // 자식 노드 관리를 위한 List(자식 노드 목록)
    protected readonly List<INode> _childNodes = new List<INode>();

    public ElementNode(string tagName)
    {
        if (string.IsNullOrWhiteSpace(tagName))
        {
            throw new ArgumentException("태그 이름은 null 또는 공백을 허용하지 않음");
        }
        this._tagName = tagName;
    }
    
    // 속성 관리
    public void SetAttribute(string key, string value)
    {
        if (string.IsNullOrWhiteSpace(key))
        {
            throw new ArgumentException("속성 키는 null 또는 공백을 허용하지 않음");
        }

        this._attributes[key] = value ?? string.Empty; // 값은 null이라면 빈 문자열로 처리함
    }

    // 자식 노드 관리
    public void AddChild(INode node)
    {
        this._childNodes.Add(node);
    }

    public void RemoveChild(INode node)
    {
        this._childNodes.Remove(node);
    }
    
    // 랜더링
    public string Render()
    {
        var sb = new StringBuilder();
        
        // 태그 생성
        sb.Append($"<{this._tagName}");
        foreach (var kvp in this._attributes)
        {
            //  속성 연결 key = "value"
            sb.Append($" {kvp.Key}=\"{kvp.Value}\"");
        }
        sb.Append(">");
        
        // 자식 노드 랜더링 (재귀적 호출)
        foreach (var child in this._childNodes)
        {
            sb.Append(child.Render());  //재귀적 호출
        }
        
        // 종료 태그 - </tagName>
        sb.Append($"</{this._tagName}>");

        return sb.ToString();  // sb를 string으로 반환
    }
}