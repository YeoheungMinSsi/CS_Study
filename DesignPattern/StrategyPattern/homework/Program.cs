namespace StrategyPattern.homework;

public class Program
{
    public static void Main(string[] args)
    {
        Context context = new Context(new JPEGStrategy());
        
        context.Upload("JavaChip.jpg");
        
        context.SetStrategy(new PNGStrategy());
        context.Upload("Cafe-late.png");
        
        context.SetStrategy(new WEBPStrategy());
        context.Upload("Cafe_logo.webp");

    }
}