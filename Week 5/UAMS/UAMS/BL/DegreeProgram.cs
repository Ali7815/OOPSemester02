using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class DegreeProgram
    {
        public string degreeName;
        public string degreeDuration;
        public List<Subject> subjects;
        public int seats;
        public DegreeProgram(string degreeName, string degreeDuration, int seats)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seats = seats;
            subjects = new List<Subject>();
        }
        
        
        public int calculateCreditHours()
        {
            int total = 0;
            for (int i = 0; i < subjects.Count; i++)
            {
                total = total + subjects[i].creditHours;
            }
            return total;
        }
        public bool isSubjectExists(Subject sub)
        {
            
            foreach (Subject i in subjects)
            {
                if (i.code == sub.code)
                {
                    return true;
                }
            }
            
            return false;
        }
        public bool AddSubject(Subject S)
        {
            int creditshours = calculateCreditHours();
            if(creditshours+S.creditHours<=20)
            {
                subjects.Add(S);
                return true;
            }
            return false;
        }

    }
}
