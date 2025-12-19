namespace Decorator2.homework;

public class Program
{
    public static void Main()
    {
        // 1. BaseImage: 원본 객체 (가장 안쪽)
        IImageFilter baseImage = new BaseImage("photo.jpg");

// 2. GrayscaleFilter: BaseImage를 감쌈 (두 번째)
        IImageFilter grayscale = new GrayscaleFilter(baseImage);

// 3. BlurFilter: GrayscaleFilter를 감쌈 (가장 바깥쪽)
        IImageFilter finalFilter = new BlurFilter(grayscale);
        
        // 예시: 흑백 후 블러
        IImageFilter chain1 = new BlurFilter(new GrayscaleFilter(new BaseImage("photo.jpg")));
        string result1 = chain1.Apply("dummy"); 
// 결과: Blur(Grayscale(photo.jpg))

// 예시: 블러 후 흑백 (순서가 다름)
        IImageFilter chain2 = new GrayscaleFilter(new BlurFilter(new BaseImage("photo.jpg")));
        string result2 = chain2.Apply("dummy");
// 결과: Grayscale(Blur(photo.jpg))
    }
}