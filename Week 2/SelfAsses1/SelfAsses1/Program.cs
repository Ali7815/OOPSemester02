using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfAsses1.BL;
using System.IO;
namespace SelfAsses1
{
    class Program
    {
        static void Main(string[] args)
        {
            List <signinup> users = new List<signinup>();
            do
            {
                string op = menu();
                if (op=="1")
                {
                    Console.Write("NAme : ");
                    string name = Console.ReadLine();
                    Console.Write("Password : ");
                    string password = Console.ReadLine();
                    check(users,name, password);

                }
                else if (op == "2")
                {
                    Console.Write("NAme : ");
                    string name = Console.ReadLine();
                    Console.Write("Password : ");
                    string password = Console.ReadLine();
                    load_data(users);
                    signup(name, password);
                }
                else if (op == "3")
                {

                    Environment.Exit(0);
                }
                else 
                {
                    Console.WriteLine("Wrong Input");
                    Console.ReadKey();
                }

            }
            while (true);
        }
        static string menu()
        {
            Console.WriteLine("1 - Signin");
            Console.WriteLine("2 - SignUp");
            Console.WriteLine("3 - Exit");
            Console.Write("Your Option....");
            string s=Console.ReadLine();
            return s;
        }
        static void check(List<signinup> users,string name,string password)
        {
            bool flag = false;
            for (int i=0; i<users.Count; i++)
            {
                if(users[i].uname==name && users[i].password==password)
                {
                    flag = true;
                    break;
                }
            }
            if (flag==true)
            {
                Console.WriteLine("Welcome to Signup Application");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Inputs");
            }
        }
        static void signup(string n,string p)
        {
            string path = "user_data.txt";
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(n + "," + p);
            file.Close();
        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void load_data(List<signinup> users)
        {
            string path = "user_data.txt";
            StreamReader file = new StreamReader(path);
            string record;
            
            signinup info = new signinup();
            while((record=file.ReadLine())!=null)
            {
                info.uname = parseData(record, 1);
                info.password = parseData(record, 2);
                users.Add(info);
            }
            file.Close();
        }
    }
}
