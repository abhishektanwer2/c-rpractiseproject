using System;
using System.Collections.Generic;
using System.Linq;


namespace c_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World ");
            List<int> list = new();
<<<<<<< ours
            list.Add(1);
            list.Add(1);
            list.Add(1);
=======
            list.Add(16); s
            list.Add(16);
            list.Add(15);
>>>>>>> theirs
            foreach (var item in list)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine(list.All(s => s.GetType() == typeof(int)));


        }
    }
}
