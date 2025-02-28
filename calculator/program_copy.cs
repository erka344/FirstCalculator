//// See https://aka.ms/new-console-template for more information
//// Console.WriteLine("Hello, World!");
//using System;
//using CalculatorLibrary;
//using CalculatorLibrary.memory;

//class Program_copy
//{
//    static void Main()
//    {
//        var calculator = new Calculator();
//        Memory? memory = null;

//        Console.Write("Enter the starting number: ");
//        if (!double.TryParse(Console.ReadLine(), out double number))
//        {
//            Console.WriteLine("Invalid number. Exiting.");
//            return;
//        }
//        calculator.Add(number);

//        while (true)
//        {
//            Console.WriteLine("Choose an operation: add, minus, memory, memory-all, or exit");
//            var operation = Console.ReadLine()?.ToLower();

//            if (operation == "exit")
//            {
//                break;
//            }

//            if (operation == "memory")
//            {
//                if (memory != null)
//                {
//                    var lastItem = memory.GetLastItem();
//                    if (lastItem != null)
//                    {
//                        Console.WriteLine("Last memory item:");
//                        Console.WriteLine($"Value: {lastItem.Value}");
//                    }
//                    else
//                    {
//                        Console.WriteLine("No items in memory.");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Memory is not being used.");
//                }
//                continue;
//            }

//            //if (operation == "memory-choose")
//            //{
//            //    Console.WriteLine("Enter the number of the memory item you want to use:");
//            //    double.TryParse(Console.ReadLine(), out double num);
//            //    if (memory.items > num)
//            //}

//            if (operation == "memory-all")
//            {
//                if (memory != null)
//                {
//                    var allItems = memory.GetAllItems();
//                    if (allItems.Any())
//                    {
//                        Console.WriteLine("All memory items:");
//                        foreach (var item in allItems)
//                        {
//                            Console.WriteLine($"Value: {item.Value}");
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("No items in memory.");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Memory is not being used.");
//                }
//                continue;
//            }

//            Console.Write("Enter a number: ");
//            if (double.TryParse(Console.ReadLine(), out number))
//            {
//                if (operation == "add")
//                {
//                    calculator.Add(number);
//                }
//                else if (operation == "minus")
//                {
//                    calculator.Minus(number);
//                }
//                else
//                {
//                    Console.WriteLine("Invalid operation.");
//                    continue;
//                }

//                Console.WriteLine($"Result: {calculator.Result}");

//                if (memory == null)
//                {
//                    memory = new Memory();
//                }
//                memory.Tuuh(calculator.Result);
//            }
//            else
//            {
//                Console.WriteLine("Invalid number.");
//            }
//        }
//    }
//}
