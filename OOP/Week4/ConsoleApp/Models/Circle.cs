namespace ConsoleApp.Models;

public class Circle : Shape
{
    public double Radius { get; set; }
    public double Area => Math.PI * Math.Pow(Radius, 2);
    public double Circumference => 2 * Math.PI * Radius;
}