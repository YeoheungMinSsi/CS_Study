using System;
using System.Collections.Generic;
using System.Linq;  // 셔플을 편하게 하는 라이브러리

namespace IteratorPattern.homework;

public class ShuffleIterator: IIterator<Song>
{
    private List<Song> _songs;
    private List<int> _shuffleIndices;  // 섞인 인덱스 번호들
    private int _position = 0;

    public ShuffleIterator(List<Song> songs)
    {
        _songs = songs;
        _shuffleIndices = new List<int>();

        for (int i = 0; i < _songs.Count; i++)
        {
            _shuffleIndices.Add(i);
        }

        // 인덱스 리스트 무작위로 섞음
        Random rand = new Random();
        _shuffleIndices = _shuffleIndices.OrderBy(x => rand.Next()).ToList();
    }

    public bool HasNext()
    {
        return _position < _songs.Count;
    }

    public Song Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("더 이상 노래가 없습니다.");
        }
        else
        {
            // 섞인 인덱스 리스트에서 현재 순서의 리스트를 가지고옴
            int targetIndex = _shuffleIndices[_position];
            _position++;
            
            return _songs[targetIndex];
        }
    }
}