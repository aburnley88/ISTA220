using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is Lab 11");
            //Console.WriteLine(Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));	
            Console.WriteLine(Util.Sum(2, 4, 6, 8, 10));
            Console.WriteLine(Util.Sum(2, 4, 6, 8));
            Console.WriteLine(Util.Sum(2, 4, 6, 8, 10, 12, 14));
        }

        static void Main()
        {
           
                doWork();
           
        }
    }
}
