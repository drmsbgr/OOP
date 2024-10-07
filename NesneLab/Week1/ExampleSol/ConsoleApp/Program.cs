using ConsoleApp.Data;

namespace ConsoleApp;

public class Program
{
    private static void Main()
    {
        var emp1 = new Employee("Ahmet", "Yılmaz", 34, 32000);
        var emp2 = new Employee("Buğra", "Durmuş", 42, 50000);
        var emp3 = new Employee("Mehmet", "Kara", 35, 35000);

        Console.WriteLine(emp1);
        Console.WriteLine(emp2);
        Console.WriteLine(emp3);

        Console.ReadKey();
    }
}