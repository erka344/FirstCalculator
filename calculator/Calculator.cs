using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator :Acalculator, IOperation
    {
        public Calculator() { }
        public void Add(double n)
        {
            Result += n;
        }
        public void Minus(double n)
        {
            Result -= n;
        }
        // Programiin main dotorh memory-iig arilgaj calculator dotor memory-iig bagtaan
    }
}
