using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3List
{
    class List<T>
    {
        public T[] items;
        public T this[int index]
        {
            get { return items[index]; }
            set { items[index] = value; }
        }

        public int Capacity { get; set; }
        public int Count { get; set; }

        public static T Add(T[] items)
        {
            Array.Resize(ref items, items.Length + 1);
            return items[items.Length - 1];
        }
       

    }
}
