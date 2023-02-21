using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SignInUp.BL;


namespace SignInUp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Credentials> users = new List<Credentials>();
            do
            {
                read_data(users);
                string op = menu();
                if (op == "1")
                {
                    signin(users);
                }
                else if (op == "2")
                {
                    signup();
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
        static void read_data(List<Credentials> users)
        {
            string path = "ids.txt";
            string record;
            StreamReader file = new StreamReader(path);
            Credentials user = new Credentials();
            while((record=file.ReadLine())!=null)
            {
                user.uname = parse_data(record, 1);
                user.password = parse_data(record, 2);
                users.Add(user);
            }
            file.Close();

        }
        static string parse_data(string record,int field)
        {
            string path = "ids.txt";
            string item = "";
            int comma=1;
            for (int i=0; i<record.Length; i++)
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
        static string menu()
        {
            Console.WriteLine("[1]- SignIn");
            Console.WriteLine("[2]- SignUp");
            Console.WriteLine("[3]- Exit");
            Console.Write("Your Option....");
            string s = Console.ReadLine();
            return s;
        }
        static void signin(List<Credentials> users)
        {
            Console.Write("Enter Name : ");
            string n = Console.ReadLine();
            Console.Write("Enter Password : ");
            string p = Console.ReadLine();
            bool flag=false;
            for (int i=0; i<users.Count; i++)
            {
                if(users[i].uname==n && users[i].password==p)
                {
                    flag = true;
                    break;
                }
                
            }
            if (flag == true)
            {
                Console.WriteLine("Welcome To SignInUp Application");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Users");
                Console.ReadKey();
            }
            Console.Clear();
        }
        static void signup()
        {
            Console.Write("Enter Name : ");
            string n= Console.ReadLine();
            Console.Write("Enter Password : ");
            string p = Console.ReadLine();
            store_data(n,p);
        }
        static void store_data(string n ,string p)
        {
            string path = "ids.txt";
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();

        }
    }
}
