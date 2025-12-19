namespace IteratorPattern.homework;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }

    public Song(string title, string artist, int duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"\"{Title} - {Artist}\"";
    }
}