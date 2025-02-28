
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using CalculatorLibrary;
using program;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace CalculatorTest
{
    [TestClass]
    public sealed class TestCalculator
    {
        private object consoleOutput;

        [TestMethod]
        public void TestAdd_calculator()
        {
            var calculator = new Calculator();
            calculator.Add(5);
            calculator.Add(10);
            calculator.Add(15);
            var lastMemoryItem = calculator.GetLastMemoryItem();
            Assert.AreEqual(30, lastMemoryItem.Value);
        }
        [TestMethod]
        public void TestMinus_calculator() 
        {
            var calculator = new Calculator();
            calculator.Add(10);
            calculator.Minus(3);
            Assert.AreEqual(7, calculator.Result);
        }
        [TestMethod]
        public void TestGetAllMemoryItems_memory()
        {
            var calculator = new Calculator();
            calculator.Add(5);
            calculator.Add(10);
            calculator.Add(15);
            var allMemoryItems = calculator.GetAllMemoryItems();
            Assert.AreEqual(3, allMemoryItems.Count);
        }
        [TestMethod]
        public void TestGetLastMemoryItem_memory()
        {
            var calculator = new Calculator();
            calculator.Add(5);
            calculator.Add(10);
            calculator.Add(15);
            var lastMemoryItem = calculator.GetLastMemoryItem();
            Assert.AreEqual(30, lastMemoryItem.Value);
        }
        [TestMethod]
        public void Test_Program()
        {
            string input = "10\nadd\n5\nexit\n";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var output = new StringWriter();
            Console.SetOut(output);

            Program.Main(); // Run the program

            string consoleOutput = output.ToString();
            StringAssert.Contains(consoleOutput, "Enter the starting number:");
            StringAssert.Contains(consoleOutput, "Result: 15");
        }
        //[TestMethod]
        public void TestInvalidOperation_program()
        {
            string input = "10\ninvalid\nexit\n";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var output = new StringWriter();
            Console.SetOut(output);

            Program.Main();

            string consoleOutput = output.ToString();
            StringAssert.Contains(consoleOutput, "Invalid operation");
        }
        [TestMethod]
        public void TestInvalidNumber_program()
        {
            string input = "abc\nexit\n";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            var output = new StringWriter();
            Console.SetOut(output);

            Program.Main();

            string consoleOutput = output.ToString();
            StringAssert.Contains(consoleOutput, "Invalid number.");
        }

    }
}
