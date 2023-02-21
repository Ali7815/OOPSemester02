using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireTruck.BL;

namespace FireTruck
{
    class Program
    {
        static void Main(string[] args)
        {
            HousePipe H = new HousePipe("plastic", "circular", 2.5F, 3);
            FireFighter F1 = new FireFighter("Ali");
            FireChief F2 = new FireChief("Haider");
            FireTruck2 t = new FireTruck2(H, F2);
            F2.drive();
            F2.extinguishFire();
            F2.delegateRespone("Ali");
            Console.ReadKey();
        }
    }
}
