namespace ConsoleApp;
using ConsoleApp.Models;

public static class Program
{
    public static void Main(string[] args)
    {
        var shape = new Shape();
        shape.SetPosition(20, 40);

        var rect = new Rectangle
        {
            Width = 16,
            Height = 16
        };
        rect.SetPosition(23, 10);

        var circle = new Circle
        {
            Radius = 5,
        };
        circle.SetPosition(0, 10);

        var tri = new Triangle
        {
            Base = 20,
            Height = 5
        };
        tri.SetPosition(71, 23);

        Console.WriteLine($"dıkdortgen alan: {rect.Area}\ndıkdortgen cevre: {rect.Circumference}");
        Console.WriteLine();
        Console.WriteLine($"daıre alan: {circle.Area}\ndaıre cevre: {circle.Circumference}");
        Console.WriteLine();
        Console.WriteLine($"ucgen alan: {tri.Area}");
    }
}