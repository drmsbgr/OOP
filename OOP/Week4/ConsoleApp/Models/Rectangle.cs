namespace ConsoleApp.Models;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area => Width * Height;
    public double Circumference => 2 * (Width + Height);
}
