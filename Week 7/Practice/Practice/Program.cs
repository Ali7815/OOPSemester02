using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.BL;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Light L = new Light();
            Console.WriteLine(L.getcolor());
            LightSaber SL = new LightSaber();
            Console.WriteLine(SL.getcolor());
            Console.ReadKey();

        }
    }
}
