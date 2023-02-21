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
                clocktype empty_time = new clocktype();
                Console.Write("Emptytime : ");
                empty_time.print_time();
                clocktype hour_time = new clocktype(8);
                Console.Write("Hour Time : ");
                hour_time.print_time();
                clocktype mint_time = new clocktype(8, 10);
                Console.Write("mint Time : ");
                mint_time.print_time();
                clocktype full_time = new clocktype(8, 10, 50);
                Console.Write("full Time : ");
                full_time.print_time();
                full_time.increment_hour();
                Console.Write("increment Hour : ");
                full_time.print_time();
                full_time.increment_mint();
                Console.Write("increment mint : ");
                full_time.print_time();
                full_time.increment_full_time();
                Console.Write("increment full time : ");
                full_time.print_time();
                bool flag = full_time.isEqual(9, 11, 51);
                Console.WriteLine("Flag : " + flag);
                flag = full_time.isEqual(9, 23, 51);
                Console.WriteLine("Object : " + flag);
                int elapsed = full_time.elapsed_time(full_time);
            Console.Write("Elapsed Seconds : " + elapsed);
               
                Console.ReadKey();
            }


        }
    }