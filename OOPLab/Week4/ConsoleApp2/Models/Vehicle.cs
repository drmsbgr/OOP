namespace ConsoleApp2.Models;

public abstract class Vehicle(string? ınfrastructure, string? model, int year)
{
    public string? Infrastructure { get; set; } = ınfrastructure;
    public string? Model { get; set; } = model;
    public int Year { get; set; } = year;
    public abstract int Seat { get; }
}