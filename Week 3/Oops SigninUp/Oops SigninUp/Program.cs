using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oops_SigninUp.BL;
using System.IO;

namespace Oops_SigninUp
{
    class Program
    {
        static List<Users> usersList = new List<Users>();
        static void Main(string[] args)
        {
            do
            {
                read_data();
                string op = menu();
                if (op == "1")
                {
                   Users u=  Signin();
                    if(u!=null)
                    {
                        if(u.isAdmin())
                        {
                            Console.WriteLine("This is Admin");
                        }
                        else
                        {
                            Console.WriteLine("This is Users");
                        }
                    }
                }
                else if (op == "2")
                {
                    Console.Clear();
                    Users u = TakeInput();
                    addusertolist(u);
                    Storedata(u);
                }
                else if (op == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input....");
                    Console.ReadKey();
                }
            }
            while (true);
        }
        static string menu()
        {
            Console.WriteLine("[1]- SignIn");
            Console.WriteLine("[2]- SignUp");
            Console.WriteLine("[3]- Exit");
            Console.Write("Your Option....");
            string s = Console.ReadLine();
            return s;
        }
        static void read_data()
        {
            string path = "ids.txt";
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                string name = parse_data(record, 1);
                string password = parse_data(record, 2);
                string role = parse_data(record, 3);
                Users u = new Users(name, password, role);
                addusertolist(u);
            }
            file.Close();

        }
        static string parse_data(string record, int field)
        {
            string path = "ids.txt";
            string item = "";
            int comma = 1;
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
        static void addusertolist(Users u)
        {
            usersList.Add(u);
        }
        static Users TakeInput()
        {
            Console.Write("Enter Name : ");
            string n = Console.ReadLine();
            Console.Write("Enter Password : ");
            string p = Console.ReadLine();
            Console.Write("Enter role : ");
            string r = Console.ReadLine();
            Users u = new Users(n, p, r);
            return u;
        }
        static void Storedata(Users u)
        {
            string path = "ids.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(u.name + "," + u.password + "," + u.role);
            file.Flush();
            file.Close();
        }
        static Users TakeInputrole()
        {
            Console.Write("Enter Name : ");
            string n = Console.ReadLine();
            Console.Write("Enter Password : ");
            string p = Console.ReadLine();
            Users u = new Users(n, p);
            return u;
        }
        static Users Signin()
        {
            Users u = TakeInputrole();
            foreach(Users storeduser in usersList)
            {
                if(storeduser.name==u.name && storeduser.password == u.password)
                {
                    return storeduser;
                }
                
            }
            return null;
        }
    }
}
