using System;
using System.Text;
using System.Collections.Generic;

namespace CompositePattern.homework;

public class ElementNode: INode
{
    // 태그 이름을 지정하는 필드
    private readonly string _tagName;

    // 속성 관리
    // Dictionary는 readonly로 불변하지만 Dictionary 내의 값은 변경가능함
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
    
    public List<ElementNode> FindByTag(string tagName)
    {
        var findNodes = new List<ElementNode>();
        
        // 노드 검사
        if (this._tagName.Equals(tagName, StringComparison.OrdinalIgnoreCase))
        {
            findNodes.Append(this);
        }
        
        // 자식 노드 재귀 검색
        foreach (var child in this._childNodes)
        {
            // 자식노드가 ElementNode 타입인지 확인
            if (child is ElementNode elementNode)
            {
                // 자식에게 findByTag를 재귀적으로 호추하고 결과를 합침
                findNodes.AddRange(elementNode.FindByTag(tagName));
            }
        }
        return findNodes;
    }
    
    // DOM트리를 JSON형태로 직렬화
    public string ToJson()
    {
        // 헬퍼 함수: JSON 문자열 내의 특수문자(주로 따옴표)를 이스케이프 처리
        // 이스케이프 처리가 완벽하지 않으면 JSON 파싱 오류를 유발할 수 있습니다.
        string EscapeJsonString(string s) => s.Replace("\"", "\\\"");

        // --- 1. 속성 JSON 문자열 생성 ---
        var attrContent = string.Join(", ",
            this._attributes.Select(kv => $"\"{EscapeJsonString(kv.Key)}\": \"{EscapeJsonString(kv.Value)}\""
            ));
        string attrJson = $"{{{attrContent}}}";

        // --- 2. 자식 노드 JSON 배열 생성 (재귀 호출) ---
        var childrenJsonContent = string.Join(", ", this._childNodes.Select(child =>
            {
                // 모든 INode는 ToJson()을 구현한다고 가정하고 재귀 호출
                // TextNode는 이전에 구현한 것처럼 텍스트만 가진 JSON을 반환해야 함.
                if (child is ElementNode element)
                    return element.ToJson();
                // TextNode가 Leaf 역할을 한다면 해당 ToJson() 결과를 반환
                // else if (child is TextNode text) return text.ToJson(); 
                return "{}"; // 알 수 없는 타입은 빈 객체로 처리
            }
        ));
        string childrenJson = $"[{childrenJsonContent}]";

        // --- 3. 최종 JSON 객체 조합 ---
        var sb = new StringBuilder();
        sb.Append("{");
        sb.Append($"\"tag\": \"{EscapeJsonString(this._tagName)}\",");
        sb.Append($"\"attributes\": {attrJson},");
        sb.Append($"\"children\": {childrenJson}");
        sb.Append("}");

        return sb.ToString();
    }
}