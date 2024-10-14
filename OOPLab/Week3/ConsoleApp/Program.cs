using ConsoleApp.Models;

var fName = "";
var lName = "";

Console.WriteLine("Adınızı Giriniz:");
fName ??= Console.ReadLine();
Console.WriteLine("Soyadınızı Giriniz:");
lName ??= Console.ReadLine();

var acc = new Account(fName, lName);
acc.CheckAccount();

while (true)
{
    Console.Clear();
    Console.WriteLine("1-Para Yatır");
    Console.WriteLine("2-Para Çek");
    Console.WriteLine("3-Hesap Bilgilerini Göster");
    Console.WriteLine("4-Hesap Aktivitesini Göster");
    Console.WriteLine("5-Çık");
    Console.WriteLine("İşlem Seçin:");
    var op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine($"Bakiye: {acc.Balance}");
            Console.WriteLine("Yatırılacak Miktar Girin:");
            var a1 = double.Parse(Console.ReadLine());
            acc.Deposit(a1);
            break;
        case 2:
            Console.WriteLine($"Bakiye: {acc.Balance}");
            Console.WriteLine("Çekilecek Miktar Girin:");
            var a2 = double.Parse(Console.ReadLine());
            acc.Withdraw(a2);
            break;
        case 3:
            acc.CheckAccount();
            Console.WriteLine("Devam etmek için herhangi bir tuşa basın.");
            Console.ReadKey();
            break;
        case 4:
            acc.AccountActivies();
            Console.WriteLine("Devam etmek için herhangi bir tuşa basın.");
            Console.ReadKey();
            break;
        case 5:
            return;
    }
}