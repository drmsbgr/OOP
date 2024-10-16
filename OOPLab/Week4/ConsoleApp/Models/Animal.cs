namespace ConsoleApp.Models;

public abstract class Animal(string? name)
{
    public string? Name { get; set; } = name;
    public abstract int Legs { get; }

    public virtual string GetSpeak()
    {
        return "animal spoke.";
    }
}