namespace ConsoleApp.Models;

public class Shape
{
    public int X { get; set; }
    public int Y { get; set; }

    public void SetPosition(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
}