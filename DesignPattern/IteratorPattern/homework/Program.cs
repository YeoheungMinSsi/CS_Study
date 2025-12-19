namespace IteratorPattern.homework;

public class Program
{
    public static void Main(string[] args)
    {
        var playlist = new Playlist();
        playlist.Add(new Song("Dream", "아이유", 210));
        playlist.Add(new Song("Next Level", "에스파", 190));
        playlist.Add(new Song("Attention", "뉴진스", 200));

        var iterator = playlist.CreateShuffleIterator();

        // 무한 반복이므로 5번만 출력해보기
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next().ToString());
        }
    }
}