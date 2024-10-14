namespace ConsoleApp.Models;

public class Circle(int x, int y) : Shape(x, y)
{
    public double Radius { get; set; }
    public double Area => Math.PI * Math.Pow(Radius, 2);
    public double Circumference => 2 * Math.PI * Radius;

    public override void Draw()
    {
        // base.Draw();
        System.Console.WriteLine("Circle has been drawn.");
    }
}