using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costumer_Product.Bl;

namespace Costumer_Product
{
    class Program
    {
        static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            float Tax = 0;
            while (true)
            {
                Console.WriteLine("Enter Option;");
                int p = int.Parse(Console.ReadLine());
                if (p == 1)
                {
                    Costumer C = Cos();
                    Product P = Pro();
                    C.getallProducts();
                    
                    Tax=Tax+P.calculateTax();


                }
                else if(p==2)
                {
                    foreach(Product store in products)
                    {
                        Console.WriteLine(Tax);
                    }

                }

                Console.ReadKey();
            }
            
        }
        static Costumer Cos()
        {
            Console.Write("Enter Name : ");
            string n = Console.ReadLine();
            Console.Write("Enter Address: ");
            string  a = Console.ReadLine();
            Console.Write("Enter Number : ");
            string num = Console.ReadLine();
            Costumer C = new Costumer(n, a, num);
            return C;
        }
        static Product Pro()
        {
            Console.Write("Enter Product Name : ");
            string n = Console.ReadLine();
            Console.Write("Enter Category: ");
            string a = Console.ReadLine();
            Console.Write("Enter Price : ");
            int price = int.Parse(Console.ReadLine());
            Product P = new Product(n, a, price);
            return P;
        }
    }
}
