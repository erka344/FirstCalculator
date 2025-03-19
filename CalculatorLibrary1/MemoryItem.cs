using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary.interfaces;

namespace CalculatorLibrary.memory
{
    public class MemoryItem : IOperation
    {
        public double Value { get; set; }

        public MemoryItem(double value)
        {
            Value = value;
        }
        public void Add(double n)
        {
            Value += n;
        }
        public void Minus(double n)
        {
            Value -= n;
        }
    }
}
