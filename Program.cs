// Console.WriteLine("=== try-catch: FormatException ===");

// try
// {
//     Console.Write("Введите число: ");
//     int number = int.Parse(Console.ReadLine());
//     Console.WriteLine($"Вы ввели: {number}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введено не число!");
// }

// Console.WriteLine("Программа продолжает работу как ни в чём не бывало");
// Console.WriteLine();
// Console.WriteLine("=== Несколько catch ===");

// Console.Write("Введите делитель: ");
// try
// {
//     int divisor = int.Parse(Console.ReadLine());
//     int result = 100 / divisor;
//     Console.WriteLine($"Результат: {result}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: это не число");
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Ошибка: нельзя делить на ноль");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
// }

// Console.WriteLine();
// Console.WriteLine("=== finally ===");

// try
// {
//     Console.WriteLine("Пытаемся выполнить операцию...");
//     int[] numbers = { 1, 2, 3 };
//     Console.WriteLine(numbers[5]);
// }
// catch (IndexOutOfRangeException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Этот блок выполнится в любом случае");
// }

// Console.WriteLine();
// Console.WriteLine("=== finally без ошибки ===");

// try
// {
//     Console.WriteLine("Операция без ошибок");
// }
// finally
// {
//     Console.WriteLine("И здесь finally тоже сработал");
// }
// Console.WriteLine();
// Console.WriteLine("=== throw ===");

// try
// {
//     double result = CalculateSquareRoot(-5);
//     Console.WriteLine(result);
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Ошибка: {ex.Message}");
// }

// double CalculateSquareRoot(double number)
// {
//     if (number < 0)
//     {
//         throw new ArgumentException("Число не может быть отрицательным");
//     }
//     return Math.Sqrt(number);
// }

// Console.WriteLine();
// Console.WriteLine("=== Собственное исключение ===");

// try
// {
//     Withdraw(1000, 1500);
// }
// catch (NegativeBalanceException ex)
// {
//     Console.WriteLine($"Операция отклонена: {ex.Message}");
// }

// Withdraw(1000, 400);

// void Withdraw(double balance, double amount)
// {
//     if (amount > balance)
//     {
//         throw new NegativeBalanceException($"Недостаточно средств: на счёте {balance}, а нужно снять {amount}");
//     }
//     Console.WriteLine($"Снято {amount}, остаток {balance - amount}");
// }

// class NegativeBalanceException : Exception
// {
//     public NegativeBalanceException(string message) : base(message)
//     {
//     }
// }


// Self 1
// int[] numbers = { 10, 20, 30, 40, 50 };

// try
// {
//     Console.Write("Enter array index (0-4): ");
//     int index = int.Parse(Console.ReadLine()!);

//     Console.WriteLine($"Value: {numbers[index]}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Error: Invalid index format.");
// }
// catch (IndexOutOfRangeException)
// {
//     Console.WriteLine("Error: Index is outside the array bounds.");
// }

// Self 2

try
{
    Console.Write("Enter age: ");
    int age = int.Parse(Console.ReadLine()!);

    CheckAge(age);

    Console.WriteLine("Age is valid.");
}
catch (FormatException)
{
    Console.WriteLine("Error: Invalid age format.");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

void CheckAge(int age)
{
    if (age < 0 || age > 120)
    {
        throw new ArgumentException(
            "Age must be between 0 and 120.");
    }
}
