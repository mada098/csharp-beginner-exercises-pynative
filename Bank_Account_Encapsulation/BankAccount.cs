namespace Bank_Account_Encapsulation;

public class BankAccount
{
    private decimal _balance;

    public void Deposit(decimal amount)
    {
        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > _balance)
        {
            Console.WriteLine("Not enough money to withdraw!");
        }
        else
        {
            _balance -= amount;
        }
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}