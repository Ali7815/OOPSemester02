using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace New_siginup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] username = new string[5];
            string[] password = new string[5];
            string path = "D:\\Semester 2\\Object Oriented Programming\\Week1\\New siginup\\newids.txt";
            do
            {
                ReadData(path,username,password);
                string op = menu();
                if (op == "1")
                {
                    Console.Write("Enter Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Password : ");
                    string pass = Console.ReadLine();
                    signin(name, pass, username, password);
                }
                else if (op=="2")
                {
                    signup(path);
                }
                else if (op == "3")
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Wrong Input");
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
            string s = Console.ReadLine();
            Console.Clear();
            return s;
        }
        static void ReadData(string path, string[] username, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    username[x] = ParseData(record, 1);
                    password[x] = ParseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }
        static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        static void signin(string n ,string p ,string[] username, string[] password)
        {
            bool flag = false;
            for (int i=0; i<5; i++)
            {
                if (n==username[i] && p==password[i])
                {
                    flag = true;
                }
            }
            if (flag==false)
            {
                Console.WriteLine("Invalid User");
            }
            else
            {
                Console.WriteLine("Welcome to Signin & Up Application");
            }
            Console.WriteLine("Press any key to Continue...");
            Console.ReadKey();
            Console.Clear();
        }
        static void signup(string path)
        {
            Console.WriteLine("Enter Name to Signup : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password to Signup: ");
            string pass = Console.ReadLine();
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(name + "," + pass);
            file.Flush();
            file.Close();
            Console.Clear();
        }
    }
}
