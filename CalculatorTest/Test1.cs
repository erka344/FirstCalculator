﻿
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using CalculatorLibrary;
using program;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using CalculatorLibrary.memory;

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
            var result1 = calculator.Result;
            Assert.AreEqual(30, result1);
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
        public void TestSave_calculator()
        {
            var calculator = new Calculator();
            calculator.Add(5);
            calculator.Save();
            calculator.Add(10);
            calculator.Save();
            calculator.Add(15);
            calculator.Save();
            var allMemoryItems = calculator.GetAllMemoryItems();
            Assert.AreEqual(3, allMemoryItems.Count);
        }

        [TestMethod]
        public void TestResultClear_calculator()
        {
            var calculator = new Calculator();
            calculator.Add(5);
            calculator.Add(1323);
            calculator.Minus(15);
            calculator.resultClear();
            Assert.AreEqual(0, calculator.Result);
        }

        [TestMethod]
        public void TestMemoryClear_calculator()
        {
            var calculator = new Calculator();
            calculator.Add(5);
            calculator.Save();
            calculator.Add(10);
            calculator.Save();
            calculator.Add(15);
            calculator.Save();
            calculator.memoryClear(0);
            var allMemoryItems = calculator.GetAllMemoryItems();
            Assert.AreEqual(2, allMemoryItems.Count);
        }

        [TestMethod]
        public void TestMemoryShow_calculator()
        {
            var calculator = new Calculator();
            calculator.Add(5);
            calculator.Save();
            calculator.Add(10);
            calculator.Save();
            calculator.Add(15);
            calculator.Save();
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                calculator.memoryShow(1);

                var result = sw.ToString().Trim();
                Assert.AreEqual("15", result); 
            };
        }

        [TestMethod]
        public void TestMemoryAdd_calculator()
        {
            var calculator = new Calculator();
            calculator.Add(5);
            calculator.Save();
            calculator.Add(10);
            calculator.Save();
            
            calculator.memoryAdd(1, 5);
            var allMemoryItems = calculator.GetAllMemoryItems();
            Assert.AreEqual(20, allMemoryItems[1].Value);
        }

        [TestMethod]
        public void TestMemoryMinus_calculator() 
        {
            var calculator = new Calculator();
            calculator.Add(5);
            calculator.Save();
            calculator.Add(10);
            calculator.Save();

            calculator.memoryMinus(1, 5);
            var allMemoryItems = calculator.GetAllMemoryItems();
            Assert.AreEqual(10, allMemoryItems[1].Value);
        }

        [TestMethod]
        public void TestGetAllMemoryItems_memory()
        {
            var calculator = new Calculator();
            calculator.Add(5);
            calculator.Save();
            calculator.Add(10);
            calculator.Save();
            calculator.Add(15);
            calculator.Save();
            var allMemoryItems = calculator.GetAllMemoryItems();
            Assert.AreEqual(3, allMemoryItems.Count);
        }
        [TestMethod]
        public void TestTuuh_Memory()
        {
            var memory = new Memory();

            // Act
            memory.Tuuh(10.5);
            memory.Tuuh(20.3);

            // Assert
            var items = memory.GetAllItems();
            Assert.AreEqual(2, memory.items.Count);
            Assert.AreEqual(10.5, memory.items[0].Value);
            Assert.AreEqual(20.3, memory.items[1].Value);
        }        
        [TestMethod]
        public void Test_MemoryItem()
        {
            var memory = new MemoryItem(23);
            Assert.AreEqual(23, memory.Value);
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
        [TestMethod]
        public void TestAction_program()
        {
            string input = "23\nadd\n27\nms\nadd\n50\nms\nmemory\n1\nminus\n25\nexit";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            using (var writer = new StringWriter())
            {w
                Console.SetOut(writer);
                Program.Main();
            }

            var calculator = new Calculator();
            var allMemoryItems = calculator.GetAllMemoryItems();
            Assert.AreEqual(50, allMemoryItems[0].Value);

            Assert.AreEqual(75, allMemoryItems[1].Value);
        }
    }
}
