using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box <element>
    {
        private List<element> items;

        public Box()
        {
            this.items = new List<element>();
        }

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public void Add(element item)
        {
            this.items.Add(item);
        }

        public element Remove()
        {
            var item = this.items[items.Count - 1];
            this.items.RemoveAt(items.Count -1); // Removes element (topmost element, index starts from 0)

            return item;
        }
    }
}
