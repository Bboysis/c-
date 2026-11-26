using System; 
abstract class BankAccount 
{ 
private string accountNumber; 
private double balance; 
public BankAccount(string accountNumber, double balance) 
{ 
this.accountNumber = accountNumber; 
this.balance = balance; 
} 
public string AccountNumber 
{ 
get { return accountNumber; } 
}
public double Balance 
{ 
get { return balance; } 
protected set { balance = value; } 
} 
public abstract void deposit(double amount); 
public abstract void withdraw(double amount); 
} 
class SavingsAccount : BankAccount 
{ 
private double amount; // amount of the last transaction 
public SavingsAccount(string accountNumber, double balance) 
: base(accountNumber, balance) { } 
public double Amount 
{ 
get { return amount; } 
set { amount = value; } 
} 
public override void deposit(double amount) 
{ 
if (amount <= 0) 
{ 
Console.WriteLine("Deposit amount must be greater than zero."); 
return; 
} 
this.amount = amount; 
Balance = Balance + amount; 
Console.WriteLine("Deposited " + amount + ". New balance: " + 
Balance); 
} 
public override void withdraw(double amount) 
{ 
if (amount <= 0) 
{ 
Console.WriteLine("Withdrawal amount must be greater than zero."); 
return; 
} 
if (amount > Balance) 
{ 
Console.WriteLine("Insufficient funds. Balance: " + Balance); 
return; 
} 
this.amount = amount; 
Balance = Balance - amount; 
Console.WriteLine("Withdrew " + amount + ". New balance: " + 
Balance); 
} 
} 
class TestBank 
{ 
static void Main() 
{ 
SavingsAccount acc = new SavingsAccount("1000562604988", 5000); 
Console.WriteLine("Account " + acc.AccountNumber + ", balance: " + 
acc.Balance); 
acc.deposit(1500); 
acc.withdraw(2000); 
acc.withdraw(10000); 
} 
}