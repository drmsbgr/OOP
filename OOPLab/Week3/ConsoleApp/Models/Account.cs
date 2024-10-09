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
            Balance = 0;
            this.FirstName = fName;
            this.LastName = lName;
            Activities = [];
            AccountDate = DateTime.Now.ToString();
        }

        public void CheckAccount()
        {
            Console.WriteLine("\nHESAP BİLGİLERİ");
            Console.WriteLine(FullName);
            Console.WriteLine($"HESAPTAKİ PARA MİKTARI: {Balance}₺");
            Console.WriteLine($"HESAP OLUŞTURULMA TARİHİ: {AccountDate}\n");
        }

        public void Deposit(float amount)
        {
            Balance += amount;
            Activities.Add($"{amount}₺ yatırıldı.");
        }

        public void Withdraw(float amount)
        {
            if (amount < 50 || amount > 10000)
                return;

            if (amount > Balance)
            {
                Activities.Add($"{Balance}₺ çekildi.");
                Balance = 0;
            }
            else
            {
                Balance -= amount;
                Activities.Add($"{amount}₺ çekildi.");
            }
        }

        public void AccountActivies()
        {
            Activities.ForEach(x => Console.WriteLine(x));
        }
    }
}