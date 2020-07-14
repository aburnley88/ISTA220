using System;

namespace ISTA220programmingexercise01
{
    class Program
    {
        static void Main(string[] args)
           
           
        {
            //introductory greeting for user
            Console.WriteLine("Part 1, circumference and area of a circle.");
           //gets radius from user of type string
            Console.Write("Enter an integer for the radius: ");
            //take user input and assign it to a variable 'strradius'
            string strradius = Console.ReadLine();
            //declares variable of int type named int radius and then calls the Parse method to convert 
            //variable strradius into an int and assig to intradius
            int intradius = int.Parse(strradius);
            //declares variable circumference of doble type and assigns value of the result of right side expression
            double circumference = 2 * Math.PI * intradius;
            //prints circumference using string interpolation
            Console.WriteLine($"the cirumference is {circumference}");
            //declares variable area of double type and assigns value equal to the result of right side expression
            double area = Math.PI * (Math.Pow(intradius, 2));
            //prints area using string interpolation
            Console.WriteLine($"The area is {area}");
            
            Console.WriteLine("Part 2, volume of a hemisphere.");
            Console.Write("Enter a number for the radius: ");
            string xradius = Console.ReadLine();
            int xntradius = int.Parse(xradius);
            double volume = (1.33 * Math.PI * (Math.Pow(xntradius,3))) /2;
            Console.WriteLine($"The volume is {volume}");
            
            
            Console.WriteLine("Part 3, area of a triangle (Heron's Formula).");
            Console.WriteLine("Please enter a number for side a: ");
            string strsidea = Console.ReadLine();
            int intsidea = int.Parse(strsidea);
            Console.WriteLine("Please enter a number for side b: ");
            string strsideb = Console.ReadLine();
            int intsideb = int.Parse(strsideb);
            Console.WriteLine("Please enter a number for side c: ");
            string strsidec = Console.ReadLine();
            int intsidec = int.Parse(strsidec);
            int P = (intsidea + intsideb + intsidec)/2;
            double areaheron = Math.Sqrt(P * (P - intsidea) * (P - intsideb) * (P - intsidec));
            Console.WriteLine($"The area is {areaheron} ");
            
            
            Console.WriteLine("Part 4, Solving a quadratic equation. ");
            Console.WriteLine("Please enter a non-negative whole number for coefficient 1: ");
            string stra = Console.ReadLine();
            int inta = int.Parse(stra);
            Console.WriteLine("Please enter a non-negative whole number for coefficient 2: ");
            string strb = Console.ReadLine();
            int intb = int.Parse(strb);
            Console.WriteLine("Please enter a non-negative whole number for coefficient 3: ");
            string strc = Console.ReadLine();
            int intc = int.Parse(strc);
            double denominator = 2 *(inta);
            double posnum = (-1 * intb) + Math.Sqrt(Math.Pow(intb, 2) - 4 * (inta) * (intc)) / denominator;
            double negnum = (-1 * intb) - Math.Sqrt(Math.Pow(intb, 2) - 4 * (inta) * (intc)) / denominator;
            Console.WriteLine($"The positive result is {posnum}, the negative result is {negnum} ");



        }
    }
}
