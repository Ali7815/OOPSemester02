using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRC_Card.BL;

namespace CRC_Card
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Student stu=takeinput();
            addstudenttolist(stu);
            Console.WriteLine(stu.calculate_merit());
            bool check =stu.eligible(80F);
            if(check==true)
            {
                Console.WriteLine("Yes...Eligible for Scholarship");
            }
            else
            {
                Console.WriteLine("No...You are not Eligibe");
            }
            Console.ReadKey();


            
        }
      static Student takeinput()
        {
            Console.WriteLine("Enter Name : ");
            string n = Console.ReadLine();
            Console.WriteLine("Enter Roll No : ");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Cgpa : ");
            float cgpa = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter MAtric MArks : ");
            float matric = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fsc Marks : ");
            float fsc = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ecat marks : ");
            float ecat = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Semester : ");
            int semester = int.Parse(Console.ReadLine());
            Console.WriteLine("EnterHome town : ");
            string home = Console.ReadLine();
            Console.WriteLine("Enter Is-Hostelite : ");
            string is_hostelite = Console.ReadLine();
            bool hostelite=false;
            if(is_hostelite=="yes" || is_hostelite=="y")
            {
                hostelite = true;
            }
            Student stu = new Student(n, roll, cgpa, matric, fsc, ecat,semester,home,hostelite);
            return stu;

        }
       static void addstudenttolist(Student s)
        {
            students.Add(s);
        }
    }
}
