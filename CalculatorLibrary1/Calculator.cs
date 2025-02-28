using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary.abstracts;
using CalculatorLibrary.interfaces;
using CalculatorLibrary.memory;


namespace CalculatorLibrary
{
    public class Calculator :Acalculator, IOperation
    {
        private Memory memory;
        public Calculator() 
        {
            // Programiin main dotorh memory-iig arilgaj calculator dotor memory-iig bagtaan
            memory = new Memory(); // memory object uusgej baina
            Result = 0;
        }
        public void Add(double n)
        {
            Result += n;
            memory.Tuuh(Result); // ur dung in memory-d hadgalna
        }
        public void Minus(double n)
        {
            Result -= n;
            memory.Tuuh(Result);
        }
        public MemoryItem? GetLastMemoryItem()
        {
            return memory.GetLastItem();
        }

        public List<MemoryItem> GetAllMemoryItems()
        {
            return (List<MemoryItem>)memory.GetAllItems();
        }
    }
}

