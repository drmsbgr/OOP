namespace ConsoleApp;
using ConsoleApp.Models;

public static class Program
{
    public static void Main(string[] args)
    {
        var shape = new Shape(20, 40);

        var rect = new Rectangle(23, 10)
        {
            Width = 16,
            Height = 16
        };

        var circle = new Circle(0, 10)
        {
            Radius = 5,
        };

        var tri = new Triangle(71, 23)
        {
            Base = 20,
            Height = 5
        };

        var list = new List<Shape>(){
            shape,
            rect,
            circle,
            tri,
            new Square(67,78){Width = 4}
        };

        foreach (var item in list)
            item.Draw();

        Console.WriteLine($"dıkdortgen alan: {rect.Area}\ndıkdortgen cevre: {rect.Circumference}");
        Console.WriteLine();
        Console.WriteLine($"daıre alan: {circle.Area}\ndaıre cevre: {circle.Circumference}");
        Console.WriteLine();
        Console.WriteLine($"ucgen alan: {tri.Area}");
    }
}