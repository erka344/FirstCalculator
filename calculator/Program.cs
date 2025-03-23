// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using CalculatorLibrary ;

namespace program;
public class Program
{
    public static void Main()
    {
        var calculator = new Calculator(); // Memory одоо Calculator дотор байна

        //Console.Write("Enter the starting number: ");
        //if (!double.TryParse(Console.ReadLine(), out double number))
        //{
        //    Console.WriteLine("Invalid number. Exiting.");
        //    return;
        //}
        //calculator.Add(number);

        while (true)
        {
            if (calculator.Result == 0)
            {
                Console.Write("Enter the starting number: ");
                if (double.TryParse(Console.ReadLine(), out double number0))
                {
                    calculator.Add(number0);
                }
                else
                {
                    Console.WriteLine("Invalid number. Please try again.");
                    continue; // Skip to the next iteration if invalid input
                }
            }
            Console.WriteLine("Choose an operation: add, minus, MS, C, History, memory or exit");
            var operation = Console.ReadLine()?.ToLower();

            if (operation == "exit")
            {
                break;
            }

            if (operation == "ms")// ur dung hadgalna
            {
                calculator.Save();
                Console.WriteLine("result is saved");
                continue;
            }

            if (operation == "c")// ur dung dahin 0 bolgoh
            {
                calculator.resultClear();
                Console.WriteLine("result is cleaned");
                continue;
            }
            if (operation == "memory")
            {
                Console.Write("Enter memory slot number: ");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    calculator.memoryShow(n);
                    while (true)
                    {
                        Console.WriteLine("Choose a memory operation: add, minus, MC, or back");
                        var memoryOperation = Console.ReadLine()?.ToLower();

                        if (memoryOperation == "add")
                        {
                            Console.Write("Enter a number: ");
                            if (double.TryParse(Console.ReadLine(), out double num1))
                            {
                                calculator.memoryAdd(n, num1);
                                calculator.memoryShow(n);
                            }
                            else
                            {
                                Console.WriteLine("Invalid number.");
                            }
                        }
                        else if (memoryOperation == "minus")
                        {
                            Console.Write("Enter a number: ");
                            if (double.TryParse(Console.ReadLine(), out double num1))
                            {
                                calculator.memoryMinus(n, num1);
                                calculator.memoryShow(n);
                            }
                            else
                            {
                                Console.WriteLine("Invalid number.");
                            }
                        }
                        else if (memoryOperation == "mc")
                        {
                            calculator.memoryClear(n);
                        }
                        else if (memoryOperation == "back")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid memory operation.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid memory slot number.");
                }
                continue;
            }

            if (operation == "history")
            {
                var allItems = calculator.GetAllMemoryItems();
                if (allItems.Any())
                {
                    Console.WriteLine("All memory items:");
                    foreach (var item in allItems)
                    {
                        Console.WriteLine($"Value: {item.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("No items in memory.");
                }
                continue;
            }

            Console.Write("Enter a number: ");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                if (operation == "add")
                {
                    calculator.Add(number);
                }
                else if (operation == "minus")
                {
                    calculator.Minus(number);
                }
                else
                {
                    Console.WriteLine("Invalid operation.");
                    continue;
                }

                Console.WriteLine($"Result: {calculator.Result}");
                
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }
}
