using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Student
    {
        public string name;
        public int age;
        public float fsc;
        public float ecat;
        public float merit;
        public List<DegreeProgram> Prefrences = new List<DegreeProgram>();
        public List<Subject> regSubject;
        public DegreeProgram regDegree;
        public Student(string name,int age,float fsc,float ecat,List<DegreeProgram> Prefrences)
        {
            this.name = name;
            this.age = age;
            this.fsc = fsc;
            this.ecat = ecat;
            this.Prefrences = Prefrences;
            regSubject = new List<Subject>();
        }
        public void calculateMerit()
        {
            this.merit = (fsc / 1100) * 60 + (ecat / 400) * 40;
        }
        public void regStudentSubject(Subject s)
        {
            int stCH = getCreditHours();
            if (regDegree != null &&
            regDegree.isSubjectExists(s) && stCH +
            s.creditHours <= 9)
            {
                regSubject.Add(s);
            }
            else
            {
                Console.WriteLine("A student cannot have more than 9 CH or Wrong Subject");
            }
        }
        public int getCreditHours()
        {
            int count = 0;
            foreach (Subject i in regSubject)
            {
                count = count + i.creditHours;

            }
            return count;
        }
        public float CalculateFee()
        {
            float fee = 0;
            foreach (Subject sub in regSubject)
            {
                fee = fee + sub.subjectFees;
            }
            return fee;
        }
    }
}
