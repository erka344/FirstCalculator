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
    public class Calculator : Acalculator, IOperation
    {
        private Memory memory;
        public Calculator()
        {
            // Programiin main dotorh memory-iig arilgaj calculator dotor memory-iig bagtaan
            memory = new Memory(); // memory object uusgej baina
            Result = 0;
        }
        public void Add(double n)//result deer n-iig nemeh
        {
            Result += n;
        }
        public void Minus(double n)// result-aas n-iig hasah
        {
            Result -= n;
        }
        public void Save()// result-iig memory-d hadgalna
        {
            memory.Tuuh(Result);
        }
        public void resultClear()// result-iig 0 bolgoh
        {
            Result = 0;
        }
        public void memoryClear(int n)// memory-d n-d hadgalj bga utgiig arilgana
        {
            if (n >= 0 && n < memory.items.Count)
            {
                memory.items.RemoveAt(n);
            }
            else
            {
                Console.WriteLine("index is invalid");
            }
        }
        public void memoryShow(int n)// memory-d n-d hadgalj bga utgiig haruulna
        {
            if (n >= 0 && n < memory.items.Count)
            {
                Console.WriteLine( memory.items[n].Value);
            }
            else
            {
                Console.WriteLine("index is invalid");
            }
        }
        public void memoryAdd(int n, double m)// memory-d n-d hadgalj bga utgiig m-eer nemegduuleh
        {
            if (n >= 0 && n < memory.items.Count)
            {
                memory.items[n].Value += m;
            }
            else
            {
                Console.WriteLine("index is invalid");
            }
        }
        public void memoryMinus(int n, double m)// memory-d n-d hadgalj bga utgiig m-eer horogduulah
        {
            if (n >= 0 && n < memory.items.Count)
            {

                memory.items[n].Value -= m;
            }
            else
            {
                Console.WriteLine("index is invalid");
            }
        }

        public List<MemoryItem> GetAllMemoryItems()// memory-d bga utguudiig butsaah
        {
            return (List<MemoryItem>)memory.GetAllItems();
        }
    }
}

