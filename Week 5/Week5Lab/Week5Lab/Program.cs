using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Lab.BL;

namespace Week5Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ali", 38, 139);
            Student s2 = new Student("Malik", 32, 150);
            Student s3 = new Student("Fahad", 14, 170);
            List<float> Name = new List<float> {4.5F,12.5F,1.0F };
            Name.Sort();
            Console.WriteLine("Name     Roll     Ecat");
            foreach (float i in Name)
            {
                Console.WriteLine(i + "    ");
            }
            Console.ReadKey();
        }
    }
}