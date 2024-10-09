namespace ConsoleApp.Models
{
    public class Account
    {
        public List<string>? Activities { get; set; }
        public double Balance { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName => $"{FirstName} {LastName?.ToUpper()}";
        public string? AccountDate { get; set; }

        public Account(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;
            AccountDate = DateTime.Now.ToString();
            Activities = [$"{FullName}, banka hesabınız oluşturuldu - {AccountDate}"];
            Balance = 0;
        }

        public void CheckAccount()
        {
            Console.WriteLine("\n-----------------------");
            Console.WriteLine("HESAP BİLGİLERİ");
            Console.WriteLine(FullName);
            Console.WriteLine($"BAKİYE: {Balance}₺");
            Console.WriteLine($"HESAP OLUŞTURULMA TARİHİ: {AccountDate}");
            Console.WriteLine("-----------------------\n");
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Activities?.Add($"{amount}₺ yatırıldı.");
        }

        public void Withdraw(double amount)
        {
            if (amount < 50 || amount > 10000)
                return;

            if (amount > Balance)
            {
                Activities?.Add($"{Balance}₺ çekildi.");
                Balance = 0;
            }
            else
            {
                Balance -= amount;
                Activities?.Add($"{amount}₺ çekildi.");
            }
        }

        public void AccountActivies()
        {
            Activities?.ForEach(x => Console.WriteLine(x));
        }
    }
}