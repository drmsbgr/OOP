namespace ConsoleApp.Models;

public class Dog(string? name) : Animal(name)
{
    public override int Legs => 4;
    public override string GetSpeak()
    {
        //base.Speak();
        return "ben köpek, hav hav";
    }
}