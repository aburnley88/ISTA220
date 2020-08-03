using System;

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 0;
            Console.WriteLine($"In part 1 i is {i}");
            Pass.value(ref i);
            Console.WriteLine($"In part 1 i is still {i}");
            Console.WriteLine("===============================");

            WrappedInt wi = new WrappedInt();
            Console.WriteLine($"In part 2 wi number is {wi.Number}");
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);

            Console.WriteLine(wi.Number);
            Console.WriteLine($"In part 2 wi number is now {wi.Number}");

        }

        static void Main(string[] args)
        {
            
                doWork();
        }
    }
}
