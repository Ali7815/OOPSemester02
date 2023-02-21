using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfAsses.BL;
namespace SelfAsses
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.Write("Enter Raduis : ");
            c.raduis = float.Parse(Console.ReadLine());
            float area = c.area();
            float circum = c.circumference();
            float dia = c.diameter();
            Console.WriteLine(area + " " + circum + " " + dia);
            Console.ReadKey();
        }
    }
}
