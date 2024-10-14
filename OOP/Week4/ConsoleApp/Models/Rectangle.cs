namespace ConsoleApp.Models;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area => Width * Height;
    public double Circumference => 2 * (Width + Height);

    public override void Draw()
    {
        // base.Draw();
        System.Console.WriteLine("Rectangle has been drawed.");
    }
}
