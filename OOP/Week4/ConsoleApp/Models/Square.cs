namespace ConsoleApp.Models;

public class Square(int x, int y) : Rectangle(x, y)
{
    public override double Height => base.Width;
    public override double Area => base.Width * Height;
    public override double Circumference => 4 * base.Width;
    public override void Draw()
    {
        // base.Draw();
        Console.WriteLine("Square has been drawn.");
    }
}
