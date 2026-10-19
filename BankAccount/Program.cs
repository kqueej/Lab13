double balance = 1000;

while (true)
{
    Console.WriteLine("1. Deposit");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
    string? choice = Console.ReadLine();

    if (choice == "0")
        break;

    if (choice != "1" && choice != "2")
        continue;

    try
    {
        Console.Write("Enter amount: ");
        double amount = double.Parse(Console.ReadLine()!);

        if (choice == "1")
            Deposit(ref balance, amount);
        else
            Withdraw(ref balance, amount);
    }
    catch (InvalidAmountException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (InsufficientFundsException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine($"Balance: {balance}");
    }
}

static void Deposit(ref double balance, double amount)
{
    if (amount <= 0)
        throw new InvalidAmountException("Amount must be greater than zero.");

    balance += amount;
}

static void Withdraw(ref double balance, double amount)
{
    if (amount <= 0)
        throw new InvalidAmountException("Amount must be greater than zero.");

    if (amount > balance)
        throw new InsufficientFundsException("Insufficient funds.");

    balance -= amount;
}

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class InvalidAmountException : Exception
{
    public InvalidAmountException(string message) : base(message) { }
}