namespace ConsoleApp.Models;

public class Rectangle(int x, int y) : Shape(x, y)
{
    public double Width { get; set; }
    public virtual double Height { get; set; }
    public virtual double Area => Width * Height;
    public virtual double Circumference => 2 * (Width + Height);

    public override void Draw()
    {
        // base.Draw();
        System.Console.WriteLine("Rectangle has been drawn.");
    }
}
