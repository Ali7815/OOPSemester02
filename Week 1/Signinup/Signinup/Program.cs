using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Signinup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] username = new string[5];
            string[] pass = new string[5];
            string path = "D:\\Semester 2\\Object Oriented Programming\\Week1\\Signinup\\ids.txt";
            
            do
            {
                readdata(path, username, pass);
                string op = menu();
                if (op=="1")
                {
                    Console.WriteLine("Enter User Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    string password = Console.ReadLine();
                    signin(name, password, username, pass);
                }
                else if (op=="2")
                {
                    signup(path);
                }
                else if (op=="3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input.......");
                    Console.ReadKey();
                }
            }
            while (true);
        }
        static string menu()
        {
            Console.WriteLine("[1]- Sign In");
            Console.WriteLine("[2]- Sign Up");
            Console.WriteLine("[3]- Exit");
            Console.Write("Your Option.....");
            string o = Console.ReadLine();
            Console.Clear();
            return o;
        }
        static string Parsedata(string record,int field)
        {
            int comma = 1;
            string item = "";
            for (int i=0; i<record.Length; i++ )
            {
                if (record[i]==',')
                {
                    comma++;
                }
                else if (comma==field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        static void readdata(string path,string[] username,string[] pass)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    username[x] = Parsedata(record, 1);
                    pass[x] = Parsedata(record, 2);
                    x++;
                    if (x>=5)
                    {
                        break;
                    }
                }
                file.Close();

            }
            
            else
            {
                Console.WriteLine("FileDoes Not Exist at current path");
            }
        }
        static void signin(string n, string p, string[] username, string[] pass)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (n == username[x] && p == pass[x])
                {
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid USer");
            }
            else
            {
                Console.WriteLine("Welcome To Sigin and Up Application");
            }
            Console.WriteLine("Press any key to Continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void signup(string path)
        {
            Console.WriteLine("Enter User Name to Signup");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password to Signup");
            string password = Console.ReadLine();

            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();
            Console.Clear();
        }
    }
}
