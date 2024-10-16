namespace ConsoleApp.Models;

public class Bird(string? name) : Animal(name)
{
    public override int Legs => 2;
    public override string GetSpeak()
    {
        //base.Speak();
        return "ben kuş, cik cik";
    }
}