public class Program
{
    public static void Main(string[] args)
    {

        var example = new Example();

        var deneme =  example.GetText("Hello");

        Console.WriteLine(deneme);

        Console.ReadKey();
    }
}