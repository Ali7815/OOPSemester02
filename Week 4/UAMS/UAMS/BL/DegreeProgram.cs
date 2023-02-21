using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class DegreeProgram
    {
        public string title;
        public string duration;
        public int seats;
        List<Subject> DegreePrograms = new List<Subject>();
      
        public DegreeProgram(string title,string duration,int seats,List<Subject> DegreePrograms)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            this.DegreePrograms = DegreePrograms;
        }
    }
}
