
// bool continueCalculating = true;

// do
// {
//     Console.WriteLine();
//     Console.WriteLine("=== Safe Calculator ===");
//     Console.Write("First number: ");
//     string? firstInput = Console.ReadLine()!;

//     try
//     {
//         int first = int.Parse(firstInput!);

//         Console.Write("Operation (+, -, *, /): ");
//         string operation = Console.ReadLine()!;

//         Console.Write("Second number: ");
//         int second = int.Parse(Console.ReadLine()!);

//         int result = operation switch
//         {
//             "+" => first + second,
//             "-" => first - second,
//             "*" => first * second,
//             "/" => first / second,
//             _ => throw new UnknownOperationException(
//                 $"Unknown operation: '{operation}'")
//         };

//         Console.WriteLine($"Result: {result}");
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Error: Invalid number format.");
//     }
//     catch (DivideByZeroException)
//     {
//         Console.WriteLine("Error: Division by zero is not allowed.");
//     }
//     catch (UnknownOperationException ex)
//     {
//         Console.WriteLine($"Operation error: {ex.Message}");
//     }
//     finally
//     {
//         Console.WriteLine("------------------------");
//     }

//     Console.Write("Continue calculating? (y/n): ");
//     string? answer = Console.ReadLine();

//     if (answer == "y")
//     {
//         continueCalculating = true;
//     }
//     else
//     {
//         continueCalculating = false;
//     }
// }
// while (continueCalculating);

// Console.WriteLine("Calculator closed.");

// class UnknownOperationException : Exception
// {
//     public UnknownOperationException(string message) : base(message)
//     {
//     }
// }
