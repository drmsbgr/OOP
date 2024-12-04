using GenericExample.Repositories;
using GenericExample.Entities;

{
    var sRepo = new StudentRepository();

    sRepo.Add(new Student(1, "Ali", "Yılmaz"));
    sRepo.Add(new Student(2, "Veli", "Kara"));
    sRepo.Add(new Student(3, "Osman", "Gültekin"));
    sRepo.Add(new Student(4, "Sinan", "Kaya"));

    Console.Write("Bir isim girin\n->");
    var name = Console.ReadLine();

    Console.WriteLine("\nBulunan Öğrenci");
    Console.WriteLine(sRepo.Search(name));

    Console.WriteLine("\nTüm öğrenciler");
    sRepo.Get().ForEach(s => Console.WriteLine($"-{s}"));
}

Console.WriteLine("Devam etmek için bir tuşa basın.");
Console.ReadKey();
Console.Clear();

{
    var cRepo = new CourseRepository();
    cRepo.Add(new Course(111, "Programlamaya Giriş I", 6));
    cRepo.Add(new Course(112, "Programlamaya Giriş II", 6));
    cRepo.Add(new Course(221, "Nesne Yönelimli Programlama", 8));
    cRepo.Add(new Course(231, "Veritabanı ve Yönetim Sistemleri", 10));

    Console.Write("Ders kodu girin\n->");
    var code = int.Parse(Console.ReadLine());

    Console.WriteLine("\nBulunan Ders");
    Console.WriteLine(cRepo.Search(code));

    Console.WriteLine("\nTüm Dersler");
    cRepo.Get().ForEach(c => Console.WriteLine($"-{c}"));
}