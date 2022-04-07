using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;

namespace ConsoleApp3List
{
    class Program
    {
        public static object Add { get; private set; }

        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            int[] items = new int[10];
            items[0] = 73;
            items[1] = 14;
            items[2] = 22;
            items[3] = 32;
            Resize(ref items, items.Length + 1);
            foreach (int item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(items.Length);
           

        }
        static void Resize<T>(ref T[] arr1, int length)
        {
            T[] arr2 = new T[length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            arr1 = arr2;
        }


    }
}
