namespace IteratorPattern.homework;

public class Playlist
{
    private List<Song> _songs = new List<Song>();

    public void Add(Song song)
    {
        _songs.Add(song);
    }

    public IIterator<Song> CreateSequentialIterator()
    {
        return new SequentialIterator(_songs);
    }

    public IIterator<Song> CreateShuffleIterator()
    {
        return new ShuffleIterator(_songs);
    }

    public IIterator<Song> CreateRepeatIterator()
    {
        return new RepeatIterator(_songs);
    }
}