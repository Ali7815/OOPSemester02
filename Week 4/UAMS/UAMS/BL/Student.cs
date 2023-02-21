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
        public float fscM;
        public float ecatM;
        public float aggre;
        public List<string> pref = new List<string>();
        public Student(string name,int age,float fscM,float ecatM,List<string> pref,float aggre)
        {
            this.name = name;
            this.age = age;
            this.fscM = fscM;
            this.ecatM = ecatM;
            this.pref = pref;
            this.aggre = aggre;
        }
        public Student()
        {    

        }
        public float calculateAggre(float fscM,float ecatM)
        {
            float aggre;
            aggre = (fscM / 1100) * 60 + (ecatM / 400) * 40;
            return aggre;
        }
    }
}
