using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator :Acalculator, IOperation
    {
        public void Add(double n)
        {
            Result += n;
        }
        public void Minus(double n)
        {
            Result -= n;
        }
    }
}
