using ConsoleApp.Data;

// List<int> numbers = [16, 19, 23, 79, 10];
// numbers.Sort();
// numbers.ForEach(Console.WriteLine);

// var myCol = new MyCollection([5, 4, 12, 8, 23, 2]);
// myCol.Add(15);
// myCol.Add(11);
// myCol.Sort();

// foreach (var item in myCol.Numbers)
//     Console.WriteLine(item);

var col = new EmployeeCollection(
    new Employee(1, "Ali", "Yılmaz", 20_000),
    new Employee(2, "Veli", "Kara", 12_000));

col.Add(new Employee(3, "Osman", "Gültekin", 25_000));

col.Sort();

foreach (var item in col)
{
    Console.WriteLine($"{item.Id} - {item.FullName} - {item.Salary}₺");
}