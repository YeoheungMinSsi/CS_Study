using System;
using System.Collections.Generic;

namespace IteratorPattern.homework;

public class SequentialIterator: IIterator<Song>
{
    private List<Song> _songs;
    private int _position = 0;  // 현재 음악 위치

    public SequentialIterator(List<Song> songs)
    {
        _songs = songs;
    }

    public bool HasNext()
    {
        // 현재 위치가 노래 리스트의 크기보다 작으면 다음노래가 존재함을 리턴(true)
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
            Song song = _songs[_position];  // 노래의 포지션
            _position++;  // 포지션 증가
            return song;  // 0부터 반환해야함으로 노래 반환 후 위치 증가
        }
    }
}