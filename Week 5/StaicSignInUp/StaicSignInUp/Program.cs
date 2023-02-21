using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaicSignInUp.BL;
using System.IO;

namespace StaicSignInUp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "ids.txt";
            read_data(path);
            while(true)
            {
                string op = menu();
                if(op=="1")
                {
                    MUser user = takeinputforsignin();
                    MUser U= MUser.checkuser(user);
                    if(U!=null)
                    {
                        if(MUser.isAdmin(U))
                        {
                            Console.WriteLine("This is Admin");
                        }
                        else
                        {
                            Console.WriteLine("Not a Admin");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Such User");
                    }
                   
                }
                else if (op == "2")
                {
                    MUser user = takeinputforsignup();
                    MUser.adduserstoList(user);
                    Storedata(user, path);
                }
                else if (op == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                    Console.ReadKey();
                }

            }
        }
        static string menu()
        {
            Console.WriteLine("[1]- Sign In");
            Console.WriteLine("[2]- Sign Up");
            Console.WriteLine("[3]- Exit");
            Console.Write("Your Option.....");
            string op = Console.ReadLine();
            return op;
        }
        static MUser takeinputforsignin()
        {
            Console.Clear();
            Console.Write("Enter UserName : ");
            string name = Console.ReadLine();
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();
            MUser user = new MUser(name, password);
            return user;
        }
        static MUser takeinputforsignup()
        {
            Console.Clear();
            Console.Write("Enter UserName : ");
            string name = Console.ReadLine();
            Console.Write("Enter Password : ");
            string password = Console.ReadLine();
            Console.Write("Enter Role : ");
            string role = Console.ReadLine();
            MUser user = new MUser(name, password,role);
            return user;
        }
        static void Storedata(MUser u,string path)
        {
            
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(u.userName + "," + u.password + "," + u.userRole);
            file.Flush();
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
        static void read_data(string path)
        {
            string record;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                string name = parse_data(record, 1);
                string password = parse_data(record, 2);
                string role = parse_data(record, 3);
                MUser u = new MUser(name, password, role);
                MUser.adduserstoList(u);
            }
            file.Close();

        }
    }
 
}
