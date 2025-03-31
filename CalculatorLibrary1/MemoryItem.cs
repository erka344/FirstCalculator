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
        /// <summary>
        /// Санах ойд хадгалагдах утга.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Санах ойн шинэ элемент үүсгэнэ.
        /// </summary>
        /// <param name="value">Эхлэлийн утга.</param>
        public MemoryItem(double value)
        {
            Value = value;
        }

        /// <summary>
        /// Санах ойд хадгалагдаж буй утгад нэмэгдэл хийх.
        /// </summary>
        /// <param name="n">Нэмэгдэх утга.</param>
        public void Add(double n)
        {
            Value += n;
        }

        /// <summary>
        /// Санах ойд хадгалагдаж буй утгаас хасалт хийх.
        /// </summary>
        /// <param name="n">Хасагдах утга.</param>
        public void Minus(double n)
        {
            Value -= n;
        }
    }

}
