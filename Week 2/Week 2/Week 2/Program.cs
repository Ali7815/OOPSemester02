using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_2.bc.BL;

namespace Week_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            students[] s = new students[10];
            
            int count = 0;
            do
            {
                string op = menu();
                if (op == "1")
                {
                    s[count] = input();
                    count = count+ 1;
                }
                else if (op == "2")
                {
                    allstudents(s,count);
                }
                else if (op == "3")
                {
                    topstudents(s,count);
                }
            }
            while (true);
        }
        static string menu()
        {
            string s;
            Console.WriteLine("[1]- Add Students");
            Console.WriteLine("[2]- Show Students");
            Console.WriteLine("[3]- Top Students");
            Console.WriteLine("Your Option......");
            s = Console.ReadLine();
            return s;
        }
        static students input()
        {
            Console.Clear();
            students s1=new students();
            Console.WriteLine("Enter Student Name : ");
            s1.name = Console.ReadLine();
            Console.WriteLine("Enter Student Roll_No : ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Cpga : ");
            s1.cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Department : ");
            s1.depart = Console.ReadLine();
            Console.WriteLine("Is Student Hostelide or Not : ");
            s1.hostelide = Console.ReadLine();
            Console.Clear();
            return s1;

        }
        static void allstudents(students[] s1,int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Records Found");
                Console.WriteLine("Press any key To Continue.....");
               
            }
            else
            {
                Console.WriteLine("Name" + "\t\t" + "Roll-No" + "\t\t" + "Cgpa" + "\t\t" + "Department" + "\t\t" + "Is_Hostelide");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(s1[i].name + "\t\t" + s1[i].roll_no + "\t\t" + s1[i].cgpa + "\t\t" + s1[i].depart[i] + "\t\t" + s1[i].hostelide);
                }
                Console.WriteLine("Press any key To Continue.....");
            }
            Console.ReadLine();
            Console.Clear();
        }
        static void topstudents(students[] s , int count)
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("No Records Found");
                Console.WriteLine("Press any key To Continue.....");
            }
            else if (count==1)
            {
                allstudents(s, count);
            }
            else if (count == 2)
            {
                for (int i=0; i<2; i++)
                {
                    int index = largest(s, i, count);
                    students temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                allstudents(s, 2);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = largest(s, i, count);
                    students temp = s[index];
                    s[index] = s[i];
                    s[i] = temp;
                }
                allstudents(s, 3);

            }
            Console.ReadKey();
            Console.Clear();
        }
        static int largest(students[] s , int start , int end)
        {
            int index = start;
            float large = s[start].cgpa;
            for (int i=start; i<end; i++)
            {
                if (large<s[i].cgpa)
                {
                    large = s[i].cgpa;
                    index = i;
                }
            }
            return index;
        }
    }
}
