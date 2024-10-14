namespace ConsoleApp.Models;

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double Area => 0.5 * Base * Height;
}