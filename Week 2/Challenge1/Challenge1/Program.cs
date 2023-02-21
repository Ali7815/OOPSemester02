using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challenge1.BL;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            products[] s = new products[10];
            int count = 0;
            do
            {
                string op = menu();
                if (op=="1")
                {
                    input();
                    count = count + 1;
                }
                else if (op=="2")
                {
                    viewproducts(s,count);
                }
                else if (op=="3")
                {
                    int sum = total(s,count);
                }
                else
                {
                    Console.WriteLine("Invalid Input....");
                    Console.ReadKey();
                }
            }
            while (true);
        }
        static string menu()
        {
            Console.WriteLine("1.Add Products");
            Console.WriteLine("2.Show Products");
            Console.WriteLine("3.Total Store Worth");
            Console.Write("Your Option.....");
            string s = Console.ReadLine();
            return s;
        }
        static products input()
        {
            products s = new products();
            Console.Clear();
            Console.Write("Enter Product ID : ");
            s.ids = Console.ReadLine();
            Console.Write("Enter Product NAme : ");
            s.name = Console.ReadLine();
            Console.Write("Enter Product Price : ");
            s.price = int.Parse(Console.ReadLine());
            Console.Write("Enter Product Category : ");
            s.category = Console.ReadLine();
            Console.Write("Enter Product BrandName : ");
            s.brandname = Console.ReadLine();
            Console.Write("Enter Product Country : ");
            s.country = Console.ReadLine();
            Console.Clear();
            return s;
        }
        static void viewproducts(products [] s1,int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Records Found");
                Console.WriteLine("Press any key To Continue.....");

            }
            else
            {
                Console.WriteLine("ID" + "\t\t" + "Name" + "\t\t" + "Price" + "\t\t" + "Category" + "\t\t" + "BrandNAme" + "\t\t" + "Country");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(s1[i].name + "\t\t" + s1[i].price + "\t\t" + s1[i].category+ "\t\t" + s1[i].brandname[i] + "\t\t" + s1[i].country);
                }
                Console.WriteLine("Press any key To Continue.....");
            }
            Console.ReadLine();
            Console.Clear();
        }
        static int total(products[] s,int count)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum = sum + s[i].price;
            }
            return sum;
        }
    }
    
}
