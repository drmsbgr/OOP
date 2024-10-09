using ConsoleApp.Models;

var acc = new Account("Buğra", "DURMUŞ");
acc.Deposit(5000);

acc.CheckAccount();

acc.Withdraw(750);
acc.Withdraw(750);
acc.Withdraw(3000);

acc.CheckAccount();

acc.Withdraw(1000);

acc.CheckAccount();

acc.AccountActivies();