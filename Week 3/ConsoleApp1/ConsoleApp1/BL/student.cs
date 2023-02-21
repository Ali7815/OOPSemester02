using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BL
{
    class clocktype
    {
        public int hour;
        public int mints;
        public int seconds;
     public clocktype()
        {
            Console.WriteLine("Welcome To CLock System");
            hour=0;
            mints = 0;
            seconds = 0;
        }
        public clocktype(int h )
        {
            hour = h;
        }
        public clocktype(int h, int m)
        {
            hour = h;
            mints = m;
        }
        public clocktype(int h,int m,int s)
        {
            hour = h;
            mints = m;
            seconds = s;
        }
     public void print_time()
        {
            Console.WriteLine(hour + " " + mints + " " + seconds);
        }
     public void increment_hour()
        {
            hour++;
        }
        public void increment_mint()
        {
            mints++;
        }
        public void increment_full_time()
        {
            seconds++;
        }
        public bool isEqual(int h,int m,int s)
        {
            if (hour==h && mints==m && seconds==s)
            {
                return true;
            }
            return false;
        }
        public bool isEqual_objec(clocktype temp)
        {
            if(temp.hour==hour && temp.mints==mints && temp.seconds==seconds)
            {
                return true;
            }
            return false;
        }
    }
}
