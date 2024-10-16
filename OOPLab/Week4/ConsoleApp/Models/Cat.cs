namespace ConsoleApp.Models;

public class Cat(string? name) : Animal(name)
{
    public override int Legs => 4;
    
    public override string GetSpeak()
    {
        //base.Speak();
        return "ben kedi, miyav miyav";
    }
}