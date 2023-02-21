using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRC_Card.BL
{
    class Student
    {
        public string name;
        public int roll_no;
        public float cgpa;
        public float matric;
        public float fsc;
        public float ecat;
        public int semester;
        public string hometown;
        public bool ishostelite;
        public bool scholarship;
        public Student(string name, int roll_no, float cgpa, float matric, float fsc, float ecat, int semester, string hometown, bool ishostelite)
        {
            this.name = name;
            this.roll_no = roll_no;
            this.cgpa = cgpa;
            this.matric = matric;
            this.fsc = fsc;
            this.ecat = ecat;
            this.semester = semester;
            this.hometown = hometown;
            this.ishostelite = ishostelite;
        }
        public float calculate_merit()
        {
            float aggre = (matric/1100)*45 + (fsc/1100)*15 + (ecat/400)*40;
            return aggre;
        }
        public bool eligible(float merit_precentage)
        {
            float merit = calculate_merit();
            if(merit>=merit_precentage && ishostelite==true)
            {
                return true;
            }
            return false;
        }
    }
}
