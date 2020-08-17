using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class SpaceShip : Vehicle
    {
        public void TakeOff()
        {
            Console.WriteLine("Taking off");
        }
        public void Land()
        {
            Console.WriteLine("Landing");
        }
        public void Fire()
        {
            Console.WriteLine("Pew Pew");
        }
        public override void Drive()
        {
            Console.WriteLine("whizzing through space");
        }
    }
}
