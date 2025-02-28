using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.memory
{
    public class MemoryItem
    {
        public double Value { get; set; }

        public MemoryItem(double value)
        {
            Value = value;
        }
    }
}
