using ProductApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var plist = new List<ProductList>{
            new ("PC", 39000, "HP"),
            new ("Mobile Phone", 13000, "Samsung"),
            new ("Speaker", 5500, "ABC"),
        };

        foreach (var item in plist)
            Console.WriteLine(item);
    }
}