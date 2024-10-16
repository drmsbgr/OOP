namespace ConsoleApp2.Models;

public class Motorcycle(string? ınfrastructure, string? model, int year) : Vehicle(ınfrastructure, model, year)
{
    public override int Seat => 2;
}