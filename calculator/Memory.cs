using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Memory
    {
        public readonly List<MemoryItem> items = new List<MemoryItem> ();
        public void Tuuh(double value)
        {
            items.Add(new MemoryItem (value));
            // list-ruu tuuh nemeh
        }

        public IEnumerable<MemoryItem> GetAllItems()
        {
            return items;
        }
        public MemoryItem? GetLastItem()
        // IEnumerable ni C#-nii interface foreach davtaltiig heregledeg
        {
            return items.Count> 0 ? items[^1] : null;
        }
    }
}
