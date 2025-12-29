using System;
using System.Collections;
using System.Collections.Generic;
namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("lkjdsaf");
            list.Add(32);
            Console.WriteLine(list.Count);

            Console.WriteLine(list.Capacity);
            int size = 0;
            Console.WriteLine(sizeof(int));
        }
    }
}
