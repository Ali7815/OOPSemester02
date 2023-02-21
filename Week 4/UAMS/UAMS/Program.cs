using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static List<DegreeProgram> programs = new List<DegreeProgram>();
        static List<Subject> subjects = new List<Subject>();
        static void Main(string[] args)
        {
           
            while (true)
            {
                string opt = menu();
                if (opt == "1")
                {
                    if (programs.Count > 0)
                    {
                        Student s = addstudent();
                        students.Add(s);
                       
                    }
                    else
                    {
                        Console.WriteLine("No Programs Available....");
                        clearscreen();

                    }
                }
                else if (opt == "2")
                {
                    DegreeProgram D = addProgram();
                    programs.Add(D);
                    
                }
                else if (opt == "3")
                {

                }
                else if (opt == "4")
                {
                    registered_student();
                }
                else if (opt == "5")
                {

                }
                else if (opt == "6")
                {
                    register_subject();
                }
                else if (opt == "7")
                {

                }
                else if (opt == "8")
                {
                    break;

                }
                else 
                {
                    Console.WriteLine("Wrong Input......");
                    Console.ReadKey();
                }
            }
        }
        static void header()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("******        UMS                         ******");
            Console.WriteLine("************************************************");
        }
        static string menu()
        {
            header();
            Console.WriteLine("[1]-Add Student");
            Console.WriteLine("[2]-Add Degree Program");
            Console.WriteLine("[3]-Generate Merit");
            Console.WriteLine("[4]-View Registered Students");
            Console.WriteLine("[5]-View Student of Specific Program");
            Console.WriteLine("[6]-Register Subject of Specific Student");
            Console.WriteLine("[7]-Caluclulate Fees for all Registered Students");
            Console.WriteLine("[8]-Exit");
            Console.Write("Your Option......");
            string op = Console.ReadLine();
            return op;
        }
        static Student addstudent()
        {
            List<string> pref = new List<string>();
            int p;
            string prefre;
            Console.Clear();
            header();
            Console.Write("Enter Student Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student fsc Marks : ");
            float fsc = float.Parse(Console.ReadLine());
            Console.Write("Enter Student Ecat marks : ");
            float ecat = float.Parse(Console.ReadLine());
            available_program();
            Console.Write("Enter Number of Prefrences : ");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Programs");
            for (int i = 0; i < p; i++)
            {
                prefre = Console.ReadLine();
                if(prefre==programs[i].title)
                {
                    pref.Add(prefre);
                }
                else
                {
                    continue;
                }
            }
            Student s1 = new Student();
            float aggre = s1.calculateAggre(fsc,ecat);


            Student stu = new Student(name, age, fsc, ecat,pref,aggre);
            Console.Clear();
            return stu;
        }
        static void clearscreen()
        {
            Console.WriteLine("Press any to Continue........");
            Console.ReadKey();
            Console.Clear();
        }
        static DegreeProgram addProgram()
        {
            List<Subject> degreeP = new List<Subject>();
            Console.Clear();
            header();
            Console.Write("Enter Degree Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Degree Duration : ");
            string dura =Console.ReadLine();
            Console.Write("Enter Seats for Degree : ");
            int seats = int.Parse(Console.ReadLine());
            Console.Write("Enter How Many subjects : ");
            int totalS = int.Parse(Console.ReadLine());
            for(int i=0;i<totalS;i++)
            {
                Console.Write("Enter Subject[" + (i+1) + "]code : ");
                string code = Console.ReadLine();
                Console.Write("Enter Subject[" + (i+1) + "]Type : ");
                string type = Console.ReadLine();
                Console.Write("Enter Subject[" + (i+1) + "]Credit Hours : ");
                int credit = int.Parse(Console.ReadLine());
                Console.Write("Enter Subject[" + (i+1) + "]Fees : ");
                int fees = int.Parse(Console.ReadLine());
                Subject S = new Subject(totalS,code, type, credit, fees);
                degreeP.Add(S);
            }

            DegreeProgram D = new DegreeProgram(name, dura, seats,degreeP);
            clearscreen();
            return D;

        }
        static void available_program()
        {
            Console.Write("Available Degree Programs : ");
            foreach (DegreeProgram temp in programs)
            {
                Console.Write(temp.title + " ");

            }
            Console.WriteLine(" ");
        }
        static void prefrences()
        {
            Console.Write("Enter Number of Prefrences : ");
            List<string> pref = new List<string>();
            int p = int.Parse(Console.ReadLine());
            for(int i=0;i<p;i++)
            {
                pref.Add(Console.ReadLine());
            }

        }
        static void registered_student()
        {
            if (students.Count > 0)
            {
                Console.Clear();
                header();
                Console.WriteLine("Name" + "\t\t " + "Age" + "\t\t " + "fscMarks" + "\t\t " + "EcatMarks");
                for (int i = 0; i < students.Count; i++)
                {
                    Console.Write(students[i].name + "\t\t " + students[i].age + "\t\t " + students[i].fscM + "\t\t\t " + students[i].ecatM + "\t\t\t");
                    for (int j = 0; j < students[i].pref.Count ; j++)
                    {
                        Console.Write(students[i].pref[j] + " ");
                    }
                    Console.WriteLine(" ");
                    
                }
            }
            else
            {
                Console.WriteLine("No Registered Student.....");
            }
            clearscreen();
        }
        static void search_specific_program()
        {
            Console.Clear();
            header();
            Console.Write("Enter a Department to Search");
            string s = Console.ReadLine();
            for(int i=0;i<programs.Count;i++)
            {
                
            }
        }
        static void register_subject()
        {
            Console.Clear();
            header();
            string n,c;
            bool flag = false;
            bool flag2 = false;
            Console.Write("Enter Name : ");
            n = Console.ReadLine();
            for (int i=0;i<students.Count; i++)
            {

                if (n == students[i].name)
                {
                    flag = true;
                }
 
                if(flag==true)
                {
                    Console.Write("Enter Subject Code : ");
                    c = Console.ReadLine();
                    for(int j=0; j<subjects.Count;j++)
                    {
                        if(c==subjects[j].code)
                        {
                            flag2 = true;
                        }
                    }


                }
            }
            if(flag==false)
            {
                Console.WriteLine("No Such Name Available;.....");
                clearscreen();
            }
            else if(flag2==false)
            {
                Console.WriteLine("No Subject available with such code....");
                clearscreen();
            }
            if(flag2==true)
            {

            }
        }
    }
}
