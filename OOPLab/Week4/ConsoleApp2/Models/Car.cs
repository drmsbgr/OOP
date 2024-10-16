namespace ConsoleApp2.Models;

public class Car(string? ınfrastructure, string? model, int year) : Vehicle(ınfrastructure, model, year)
{
    public override int Seat => 4;
}