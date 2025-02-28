﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using CalculatorLibrary ;


public class Program
{
    static void Main()
    {
        var calculator = new Calculator(); // Memory одоо Calculator дотор байна

        Console.Write("Enter the starting number: ");
        if (!double.TryParse(Console.ReadLine(), out double number))
        {
            Console.WriteLine("Invalid number. Exiting.");
            return;
        }
        calculator.Add(number);

        while (true)
        {
            Console.WriteLine("Choose an operation: add, minus, memory, memory-all, or exit");
            var operation = Console.ReadLine()?.ToLower();

            if (operation == "exit")
            {
                break;
            }

            if (operation == "memory")
            {
                var lastItem = calculator.GetLastMemoryItem();
                if (lastItem != null)
                {
                    Console.WriteLine("Last memory item:");
                    Console.WriteLine($"Value: {lastItem.Value}");
                }
                else
                {
                    Console.WriteLine("No items in memory.");
                }
                continue;
            }

            if (operation == "memory-all")
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
            if (double.TryParse(Console.ReadLine(), out number))
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
