using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    class Subject
    {
        public int tsubjects;
        public string code;
        public int creditH;
        public string subjectType;
        public int subjectsFee;
        public Subject(int tsubjects,string code,string subjectType,int creditH, int subjectsFee)
        {
            this.tsubjects = tsubjects;
            this.code = code;
            this.creditH = creditH;
            this.subjectType = subjectType;
            this.subjectsFee = subjectsFee;
        }
    }
}
