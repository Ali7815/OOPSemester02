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
        static List<Student> studentsList = new List<Student>();
        static List<DegreeProgram> DegreeList = new List<DegreeProgram>();
        static List<Student> sortedStudent = new List<Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                string opt = menu();
                if (opt == "1")
                {
                    if (DegreeList.Count > 0)
                    {
                        Student S = addstudent();
                        studentsList.Add(S);
                        sortedStudent.Add(S);

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
                    DegreeList.Add(D);

                }
                else if (opt == "3")
                {
                    sortedStudentByMerit();
                    giveadmission();
                    print();
                }
                else if (opt == "4")
                {
                    viewregisterStudent();

                }
                else if (opt == "5")
                {
                    Console.WriteLine("Enter Degree Name : ");
                    string degname = Console.ReadLine();
                    viewstudentinDegree(degname);

                }
                else if (opt == "6")
                {
                    Console.WriteLine("Enter Student Name : ");
                    string name = Console.ReadLine();
                    Student s=searchStudent(name);
                    if(s!=null)
                    {
                        vewsubject(s);
                        registersubjects(s);
                        
                    }
                }
                else if (opt == "7")
                {
                    CalculateFeeAll();
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
            string dura = Console.ReadLine();
            Console.Write("Enter Seats for Degree : ");
            int seats = int.Parse(Console.ReadLine());
            Console.Write("Enter How Many subjects : ");
            int totalS = int.Parse(Console.ReadLine());
            for (int i = 0; i < totalS; i++)
            {
                Console.Write("Enter Subject[" + (i + 1) + "]code : ");
                string code = Console.ReadLine();
                Console.Write("Enter Subject[" + (i + 1) + "]Type : ");
                string type = Console.ReadLine();
                Console.Write("Enter Subject[" + (i + 1) + "]Credit Hours : ");
                int credit = int.Parse(Console.ReadLine());
                Console.Write("Enter Subject[" + (i + 1) + "]Fees : ");
                int fees = int.Parse(Console.ReadLine());
                Subject S = new Subject(code, type, credit, fees);
                degreeP.Add(S);
            }

            DegreeProgram D = new DegreeProgram(name, dura, seats);
            clearscreen();
            return D;
        }
        static Student addstudent()
        {
            List<DegreeProgram> pref = new List<DegreeProgram>();
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
            foreach (DegreeProgram d in DegreeList)
            {
                bool flag = false;
                prefre = Console.ReadLine();
                if (prefre == d.degreeName && !(pref.Contains(d)))
                {
                    pref.Add(d);
                    flag = true;
                }
                else if(flag==false)
                {
                    Console.WriteLine("Enter Valid Degree Program");
                }
            }
            Student stu = new Student(name, age, fsc, ecat, pref);
            Console.Clear();
            return stu;
        }
        static void available_program()
        {
            Console.Write("Available Degree Programs : ");
            foreach (DegreeProgram temp in DegreeList)
            {
                Console.Write(temp.degreeName + " ");

            }
            Console.WriteLine(" ");
        }
        static void sortedStudentByMerit()
        {
            List<Student> SortedList = sortedStudent.OrderByDescending(o => o.merit).ToList();
           
        }
        static void giveadmission()
        {
            foreach (Student s in studentsList)
            {
                foreach (DegreeProgram d in s.Prefrences)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }
        static void print()
        {
            foreach(Student s in studentsList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + " Got Admission in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.name + " Did npt get admission in");
                }
            }
            Console.Clear();
        }
        static Student searchStudent(string name)
        {
            foreach (Student S in studentsList)
            {
                if(name==S.name && S.regDegree!=null)
                {
                    return S;
                }
            }
            return null;
        }
        static void CalculateFeeAll()
        {
            foreach (Student S in studentsList)
            {
                if(S.regDegree!=null)
                {
                    Console.WriteLine(S.name + " has " + S.CalculateFee() + " Fees ");
                }
            }
        }
        static void viewstudentinDegree(string degreename)
        {
            Console.Clear();
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach (Student s in studentsList)
            {
                if(s.regDegree!=null)
                {
                    if(degreename==s.regDegree.degreeName)
                    {
                        Console.WriteLine(s.name + "\t" + s.fsc + "\t" + s.ecat + "\t" + s.age);
                    }
                }
            }
        }
        static void viewregisterStudent()
        {
            Console.WriteLine("Name\tFSC\tEcat\tAge");
            foreach (Student s in studentsList)
            {
                if(s.regDegree!=null)
                {
                    Console.WriteLine(s.name + "\t" + s.fsc + "\t" + s.ecat + "\t" + s.age);
                }
            }
            clearscreen();
        }
        static void vewsubject(Student s)
        {
            if(s.regDegree!=null)
            {
                Console.WriteLine("SubjectCode\tSubjectType");
                foreach (Subject sub in s.regDegree.subjects)
                {
                    Console.WriteLine(sub.code + "\t" + sub.type);
                }
            }
            
        }
        static void registersubjects(Student s)
        {
            Console.Write("Enter How many subject want to enter : ");
            int count=int.Parse(Console.ReadLine());
            for(int i=0; i<count; i++)
            {
                Console.Write("Enter Subject Code : ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                {
                    if(code==sub.code && !(s.regSubject.Contains(sub)))
                    {
                        s.regStudentSubject(sub);
                        flag = true;
                        break;
                    }
                    if(flag==false)
                    {
                        Console.WriteLine("Enter Valid Code...");
                        i--;
                    }
                }
            }
        }


    }
    }
