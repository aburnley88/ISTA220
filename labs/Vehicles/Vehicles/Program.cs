//A Simple program that uses inheritance to display the uses and functions of inheritance. 
//Arnold Burnley

using System;
using System.Runtime.CompilerServices;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is Vehicles Lab");
            Console.WriteLine("======================================================================================");
            
            Console.WriteLine("Journey by airplane");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");
           
            Console.WriteLine("======================================================================================");
            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");
          
            Console.WriteLine("======================================================================================");
            
            Console.WriteLine("Testing polymorphism");
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
           
            Console.WriteLine("======================================================================================");

            SpaceShip challenger = new SpaceShip();
            challenger.StartEngine("boooom");
            challenger.TakeOff();
            challenger.Drive();
            challenger.Fire();
            challenger.Land();
            challenger.StopEngine("ssssssssssss");

        }

        static void Main()
        {
            
                doWork();
           
            
        }
    }
}
