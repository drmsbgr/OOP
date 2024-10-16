using ConsoleApp2.Models;

var car = new Car("Mercedes", "Benz", 1998);
var motorcycle = new Motorcycle("Vevev", "Bubby", 1995);
var bus = new Bus("Renault", "Umru", 2003);
var truck = new Truck("Volvo", "Xux", 1991);

var vehicles = new List<Vehicle>(){
    car,
    motorcycle,
    bus,
    truck,
};

vehicles.ForEach(v =>
{
    Console.WriteLine($"Marka:{v.Infrastructure}\nModel:{v.Model}\nYıl:{v.Year}\nKoltuk:{v.Seat}\n");
});