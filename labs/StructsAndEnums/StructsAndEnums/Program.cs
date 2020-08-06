#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("this is structs and enums");
            Month first = Month.December;
            Console.WriteLine(first);
            first++;
            Console.WriteLine(first);
            Console.WriteLine((int)first);
            Month last = Month.December;
            Console.WriteLine(last);
            Console.WriteLine((int)last);

            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);
            Date weddingAnniversary = new Date(2022, Month.February, 22);
            Console.WriteLine(weddingAnniversary);

            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");
            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniversaryCopy}");





        }

        static void Main()
        {          
                doWork();
      
        }
    }
}
