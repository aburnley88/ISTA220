using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextHello
{
    public class Program
    {//static means only 1 instance of the method can be used
       public  static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            string name; //declares variable of type string named 'name'
            Console.Write("Enter your name: "); //promtps user to enter name
            name = Console.ReadLine();//ReadLine method reads input from the console up to a new line
            Console.WriteLine($"Hello, {name}");//difference between Write and WriteLine is the latter writes to a new line
        }
    }
}
