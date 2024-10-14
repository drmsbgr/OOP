namespace ConsoleApp.Models;

public class Triangle(int x, int y) : Shape(x, y)
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double Area => 0.5 * Base * Height;


    public override void Draw()
    {
        // base.Draw();
        System.Console.WriteLine("Triangle has been drawn.");
    }
}