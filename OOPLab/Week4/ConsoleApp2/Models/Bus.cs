namespace ConsoleApp2.Models;

public class Bus(string? ınfrastructure, string? model, int year) : Vehicle(ınfrastructure, model, year)
{
    public override int Seat => 24;
}