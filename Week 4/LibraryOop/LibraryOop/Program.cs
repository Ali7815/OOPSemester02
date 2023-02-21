using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOop.BL;

namespace LibraryOop
{
    class Program
    {
        static List<Book> bookslist = new List<Book>();
        static void Main(string[] args)
        {
            List<string> chapters = new List<string> { "Wave", "Sound", "Dynamtics", "Nuclear" };
            Book physics = new Book("Newton", "Fundamental Of Physics", 1000, 500, chapters);

            Console.WriteLine(" Chapter :" + physics.getChapter(2));
            physics.setbookmark(452);
            Console.WriteLine(" book Mark :" + physics.getbookmark());
            Console.WriteLine(" Price : " + physics.());
            physics.setprice(600);
            Console.WriteLine(" Price : " + physics.getprice());
            physics.Chapters("Force");

            Console.ReadKey();


            }
        }
       
    }
