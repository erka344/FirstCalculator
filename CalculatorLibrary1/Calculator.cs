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
        /// <summary>
        /// Санах ойг хадгалах объект.
        /// </summary>
        public Memory memory { get; set; }

        /// <summary>
        /// Калькуляторын шинэ объект үүсгэж, санах ойг эхлүүлнэ.
        /// </summary>
        public Calculator()
        {
            // Program-ийн main доторх memory-ийг арилгаж,
            // Calculator дотор memory-г багтаана.
            memory = new Memory(); // Санах ойн объект үүсгэж байна.
            Result = 0;
        }

        /// <summary>
        /// Өгөгдсөн утгыг одоогийн result дээр нэмнэ.
        /// </summary>
        /// <param name="n">Нэмэгдэх тоон утга.</param>
        public void Add(double n)
        {
            Result += n;
        }

        /// <summary>
        /// Өгөгдсөн утгыг одоогийн result-ээс хасна.
        /// </summary>
        /// <param name="n">Хасагдах тоон утга.</param>
        public void Minus(double n)
        {
            Result -= n;
        }

        /// <summary>
        /// Одоогийн result-ыг санах ойд хадгална, мөн хадгалсан утгыг буцаана.
        /// </summary>
        /// <returns>Санах ойд хадгалсан утга.</returns>
        public MemoryItem Save()
        {
            MemoryItem memoryItem = new MemoryItem(Result);
            memory.items.Add(memoryItem);
            return memoryItem;
        }


        /// <summary>
        /// Одоогийн result-ыг 0 болгож цэвэрлэнэ.
        /// </summary>
        public void resultClear()
        {
            Result = 0;
        }

        /// <summary>
        /// Санах ой дахь тодорхой индексийн утгыг устгана.
        /// </summary>
        /// <param name="n">Устгах индекс.</param>
        public void memoryClear(int n)
        {
            if (n >= 0 && n < memory.items.Count)
            {
                memory.items.RemoveAt(n);
            }
            else
            {
                Console.WriteLine("Индекс буруу байна.");
            }
        }

        /// <summary>
        /// Санах ой дахь тодорхой индексийн утгыг харуулна.
        /// </summary>
        /// <param name="n">Харах индекс.</param>
        public void memoryShow(int n)
        {
            if (n >= 0 && n < memory.items.Count)
            {
                Console.WriteLine(memory.items[n].Value);
            }
            else
            {
                Console.WriteLine("Индекс буруу байна.");
            }
        }

        /// <summary>
        /// Санах ой дахь тодорхой индексийн утгыг нэмэгдүүлнэ.
        /// </summary>
        /// <param name="n">Зорилтот индекс.</param>
        /// <param name="m">Нэмэгдэх тоон утга.</param>
        public void memoryAdd(int n, double m)
        {
            if (n >= 0 && n < memory.items.Count)
            {
                memory.items[n].Value += m;
            }
            else
            {
                Console.WriteLine("Индекс буруу байна.");
            }
        }

        /// <summary>
        /// Санах ой дахь тодорхой индексийн утгыг багасгана.
        /// </summary>
        /// <param name="n">Зорилтот индекс.</param>
        /// <param name="m">Хасагдах тоон утга.</param>
        public void memoryMinus(int n, double m)
        {
            if (n >= 0 && n < memory.items.Count)
            {
                memory.items[n].Value -= m;
            }
            else
            {
                Console.WriteLine("Индекс буруу байна.");
            }
        }

        /// <summary>
        /// Санах ой дахь бүх элементүүдийг буцаана.
        /// </summary>
        /// <returns>Санах ойд хадгалагдаж буй бүх элементүүд.</returns>
        public List<MemoryItem> GetAllMemoryItems()
        {
            return (List<MemoryItem>)memory.GetAllItems();
        }
    }

}

