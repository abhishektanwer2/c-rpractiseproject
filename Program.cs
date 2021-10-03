using System;
using System.Collections.Generic;

namespace c_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World ");
            List<int> list = new();
            list.Add(1);
            list.Add(23);
            list.Add(35);
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }


        }
    }
}
