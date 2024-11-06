using StudentManagementApp.Models;

var students = new StudentCollection
{
    new Student("Ali", "Veli", "Makine", 11231),
    new Student("Buğra", "Durmuş", "Yazılım", 11211),
    new Student("Büşra", "Kaya", "Endüstri", 14231),
    new Student("Mustafa", "Çoban", "Biyomedikal", 19751),
    new Student("Sıla", "Yılmaz", "Hukuk", 23153)
};

Console.WriteLine($"{students[0]:1}");
Console.WriteLine();
Console.WriteLine($"{students[1]}");
Console.WriteLine();
Console.WriteLine($"{students[2]:2}");
Console.WriteLine();
Console.WriteLine($"{students[3]:1}");
Console.WriteLine();
Console.WriteLine($"{students[4]:2}");