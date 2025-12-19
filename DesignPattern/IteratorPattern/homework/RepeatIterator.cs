namespace IteratorPattern.homework;

public class RepeatIterator: IIterator<Song>
{
    private List<Song> _songs;
    private int _position = 0;

    public RepeatIterator(List<Song> songs)
    {
        _songs = songs;
    }

    public bool HasNext()
    {
        return _songs.Count > 0;  // 노래가 하나라도 있다면 true -> 무한 반복하기 위해
    }

    public Song Next()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("재생할 노래가 없습니다.");
        }

        Song song = _songs[_position];
        // 다음 위치로 이동하되 리스트의 모든 노래가 끝나면 다시 0으로
        _position = (_position + 1) % _songs.Count;
        return song;
    }
}