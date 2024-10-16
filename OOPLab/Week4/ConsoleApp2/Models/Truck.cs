namespace ConsoleApp2.Models;

public class Truck(string? ınfrastructure, string? model, int year) : Vehicle(ınfrastructure, model, year)
{
    public override int Seat => 3;
}