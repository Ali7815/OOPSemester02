using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTruck.BL
{
    class FireChief : FireFighter
    {
        public FireChief(string name) : base(name)
        {
            this.name = name;
        }
        public void delegateRespone(string fireFighterName)
        {
            Console.WriteLine("Tell" + fireFighterName + " to extinguish the fire");
        }
    }
}
