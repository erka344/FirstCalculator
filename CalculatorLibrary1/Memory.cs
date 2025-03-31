using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.memory
{
    public class Memory
    {
        /// <summary>
        /// Санах ойд хадгалах элементүүдийн жагсаалт.
        /// </summary>
        public readonly List<MemoryItem> items = new List<MemoryItem>();


        /// <summary>
        /// Санах ойгоос тодорхой нэг элемент устгана.
        /// </summary>
        /// <param name="item">Устгах элемент.</param>
        public void clearItem(MemoryItem item)
        {
            items.Remove(item);
        }

        /// <summary>
        /// Санах ой дахь бүх элементүүдийг буцаана.
        /// </summary>
        /// <returns>Санах ойд хадгалагдаж буй бүх элемент.</returns>
        public IEnumerable<MemoryItem> GetAllItems()
        {
            return items;
        }
    }

}
