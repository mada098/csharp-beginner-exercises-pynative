using Bank_Account_Encapsulation;

var myAccount = new BankAccount();
myAccount.Deposit(500);
myAccount.Withdraw(200);

Console.WriteLine($"Balance = {myAccount.GetBalance()}");