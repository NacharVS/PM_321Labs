using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs320
{
    internal class Item
    {
        public Item(string itemName, int itemCount)
        {
            ItemName = itemName;
            ItemCount = itemCount;
        }

        public string ItemName { get; set; }
        public int ItemCount { get; set; }
    }
}
