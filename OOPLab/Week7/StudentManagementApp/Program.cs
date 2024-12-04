using StudentManagementApp.Models;

var students = new StudentCollection
{
    new Student("Ali", "Veli", "Makine", 11231),
    new Student("Buğra", "Durmuş", "Yazılım", 11211),
    new Student("Büşra", "Kaya", "Endüstri", 14231),
    new Student("Mustafa", "Çoban", "Biyomedikal", 19751),
    new Student("Sıla", "Yılmaz", "Hukuk", 23153)
};

foreach (var item in students)
    Console.WriteLine(item);

var student = (Student)students[1].Clone();

Console.WriteLine(student.ToString("1", null));
Console.WriteLine(student.ToString("2", null));
Console.WriteLine(student.ToString("", null));