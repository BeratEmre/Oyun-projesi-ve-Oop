using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.FindIndex(2));
        }
    }
}
