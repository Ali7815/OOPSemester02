using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTruck.BL
{
    class FireFighter
    {
        protected string name;
        public FireFighter(string name)
        {
            this.name = name;
        }
        public void drive()
        {
            Console.WriteLine(name + " is driving the truck");
        }
        public void extinguishFire()
        {
            Console.WriteLine(name + " is driving the truck");
        }
    }
}
