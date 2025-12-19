namespace IteratorPattern2.homework;

public class Program
{
    public static void Main(string[] args)
    {
        var root = new Directory("root");
        var src = new Directory("src");
        
        src.Add(new File("index.ts"));
        src.Add(new File("app.ts"));

        var docs = new Directory("docs");
        docs.Add(new File("README.md"));

        root.Add(src);
        root.Add(docs);
        root.Add(new File("package.json"));

        var iterator = new DirectoryIterator(root);
        while (iterator.HasNext()) 
        {
            Console.WriteLine(iterator.Next().GetName());
        }    
    }
}