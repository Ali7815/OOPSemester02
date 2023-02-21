using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Lab.BL
{
    class Student
    {
        public string name;
        public int rollno;
        public int ecat;
        public Student(string name,int rollno,int ecat)
        {
            this.name = name;
            this.rollno = rollno;
            this.ecat = ecat;
        }
    }
}
