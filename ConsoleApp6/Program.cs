using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {


        public static void Main()
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            Sorting(a);
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
        public static void Sorting(List<int> a)
        {
            a.Add(1);
            if (a.Count < 10)
            {
                Sorting(a);                
            }

        }

        // очень ценный коммент
        


    }
}