using BankApp.Entities;
using BankApp.Repositories;

var context = new BankingContext();
var bankRepo = new BankRepository(context);

bankRepo.Add(new Bank());

var customerRepo = new CustomerRepository(context);
var accountRepo = new AccountRepository(context);

while (true)
{
    Console.WriteLine("İşlem Seçin");
    Console.WriteLine("1- Banka Ekle");
    Console.WriteLine("2- Müşteri Ekle");
    Console.WriteLine("3- Hesap Ekle");
    Console.WriteLine("4- Hesap Listele");
    Console.WriteLine("5- İşlem Ekle");
    Console.WriteLine("6- İşlem Geçmişi Gör");
    Console.WriteLine("7- Çık");
    var option = Console.ReadLine();
    if (int.TryParse(option, out var optionNo))
    {
        if (optionNo == 7)
            break;

        switch (optionNo)
        {
            case 1:
                AddBank();
                break;
            case 2:
                AddCustomer();
                break;
            case 3:
                AddAccount();
                break;
            case 4:
                ListAccounts();
                break;
            case 5:
                AddTransaction();
                break;
            case 6:
                ReviewTransactions();
                break;
            default:
                continue;
        }
    }
    else continue;
}

void AddBank()
{
    Console.WriteLine("---Banka Ekle---");
    Console.Write("Banka ismi girin:");
    var bankName = Console.ReadLine();
    Console.Write("Banka adresi girin:");
    var bankAddress = Console.ReadLine();

    var bank = new Bank() { Name = bankName, Address = bankAddress };
    bankRepo.Add(bank);
}

void AddCustomer()
{
    Console.WriteLine("---Müşteri Ekle---");
    Console.Write("Müşteri ismi girin:");
    var customerName = Console.ReadLine();
    Console.Write("Eposta adresi girin:");
    var customerMail = Console.ReadLine();
    Console.Write("banka id girin:");
    var bankId = int.Parse(Console.ReadLine());

    var customer = new Customer() { FullName = customerName, Email = customerMail, BankId = bankId };
    customerRepo.Add(customer);
}

void AddAccount()
{
    Console.WriteLine("---Hesap Ekle---");
    Console.Write("Müşteri id girin:");
    var customerId = int.Parse(Console.ReadLine());
    Console.Write("hesap no girin:");
    var accountNo = int.Parse(Console.ReadLine());

    var account = new Account() { AccountNo = accountNo, Balance = 0, CustomerId = customerId };
    accountRepo.Add(account);
}

void ListAccounts()
{
    Console.WriteLine("---Hesapları Listele---");
    Console.Write("Müşteri id girin:");
    var customerId = int.Parse(Console.ReadLine());

    var accounts = accountRepo.GetAll().FindAll(x => x.CustomerId == customerId);

    accounts.ForEach(a =>
    {
        Console.WriteLine($"No:{a.AccountNo}\nBakiye:{a.Balance}\n");
    });
}

void AddTransaction()
{
    Console.WriteLine("---İşlem Ekle---");
    Console.WriteLine("Hesap no girin:");
    var accountNo = int.Parse(Console.ReadLine());
    var account = accountRepo.GetAll().Find(x => x.AccountNo == accountNo);

    while (true)
    {
        Console.WriteLine("İşlem tipi seç:");
        Console.WriteLine("1 - Para Yatır");
        Console.WriteLine("2 - Para Çek");
        var option = Console.ReadLine();

        if (int.TryParse(option, out int optionNo))
        {
            if (optionNo == 1 || optionNo == 2)
            {
                Console.WriteLine("Miktar gir:");
                var amount = int.Parse(Console.ReadLine());

                var transactionLog = new Transaction()
                {
                    Amount = amount,
                    Date = DateTime.Now,
                    AccountId = account.Id
                };

                if (optionNo == 1)
                {
                    account.Balance += amount;
                }
                else
                {
                    if (account.Balance >= amount)
                        account.Balance -= amount;
                }

                context.Transactions.Add(transactionLog);
                context.SaveChanges();

                break;
            }

            else continue;
        }
        else continue;
    }
}

void ReviewTransactions()
{
    Console.WriteLine("---İşlemleri Listele---");
    Console.Write("hesap id girin:");
    var accountId = int.Parse(Console.ReadLine());
    var transactions = context.Transactions.ToList().FindAll(x => x.AccountId == accountId);

    transactions.ForEach(t =>
        {
            Console.WriteLine($"İşlem Miktar:{t.Amount}\nTarih:{t.Date}");
        });
}
