using ConsoleApp.Models;

var dog = new Dog("fındık");
var cat = new Cat("karamel");
var bird = new Bird("serçecik");

var animals = new List<Animal>()
{
    dog,
    cat,
    bird
};

animals.ForEach(x =>
{
    Console.WriteLine($"{x.Name}");
    Console.WriteLine($"-{x.GetSpeak()}");
    Console.WriteLine($"{x.Legs} tane ayagım var.");
    Console.WriteLine("");
});