using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignInUpOopApproach.BL;
using System.IO;

namespace SignInUpOopApproach
{
    class Program
    {
        static List<MUser> Users = new List<MUser>();
        static void Main(string[] args)
        {
            string path = "ids.txt";
            Load_Data(path);
            while (true)
            {
                string op = menu();
                if(op=="1")
                {
                    Console.Clear();
                    MUser User=Signin();
                    if(User!=null)
                    {
                        if(User.Role=="Admin")
                        {
                            Console.WriteLine("This is Admin");
                        }
                        else
                        {
                            Console.WriteLine("This not Admin");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Wrong Username & Password");
                    }
                    
                }
                else if (op == "2")
                {
                    MUser User = SignUp();
                    AddUserToList(User);
                    Store_Data(path, User);
                }
                else if (op == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Input....");
                    Console.ReadKey();
                    Console.Clear();
                }


            }


        }
        static string menu()
        {
            Console.WriteLine("[1]- Signin");
            Console.WriteLine("[2]- SignUp");
            Console.WriteLine("[3]-Exit");
            Console.Write("Your Option.....");
            string o = Console.ReadLine();
            
            return o;
        }
        static MUser Signin()
        {
            MUser user = TakeInputFromConsole();
            foreach(MUser storeUser in Users)
            {
                if(user.Name==storeUser.Name && user.Password==storeUser.Password)
                {
                    return storeUser;
                }
                
            }
            return null;
        }
        static MUser TakeInputFromConsole()
        {
            Console.Write("Enter Name :");
            string n = Console.ReadLine();
            Console.Write("Enter Password :");
            string p = Console.ReadLine();
            MUser User = new MUser(n, p);
            return User;


        }
        static MUser SignUp()
        {
            Console.Write("Enter Name :");
            string n = Console.ReadLine();
            Console.Write("Enter Password :");
            string p = Console.ReadLine();
            Console.Write("Enter Role :");
            string r = Console.ReadLine();
            MUser User = new MUser(n, p,r);
            return User;
        }
        static void AddUserToList(MUser User)
        {
            Users.Add(User);
        }
        static void Store_Data(string path,MUser User)
        {
            StreamWriter file = new StreamWriter(path,true);
            file.WriteLine(User.Name + "," + User.Password + "," + User.Role);
            file.Flush();
            file.Close();

        }

        static void Load_Data(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record="";
                while((record=file.ReadLine())!=null)
                {
                    string name = Parse_Data(record, 1);
                    string password = Parse_Data(record, 2);
                    string role = Parse_Data(record, 3);
                    MUser User = new MUser(name, password, role);
                    AddUserToList(User);
                }
                file.Close();

            }
            else
            {
                Console.WriteLine("No File Exist");
            }
            
        }
        static string Parse_Data(string record,int field)
        {
            string item="";
            int comma = 1;
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i]==',')
                {
                    comma++;
                }
                else if(field==comma)
                {
                    item = item + record[i] ;
                }
            }
            return item;
        }
    }
}
