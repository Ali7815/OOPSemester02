using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.DL;
using Ocean_Navigation.UI;

namespace Ocean_Navigation.BL
{
    class Angle
    {
        public int degree;
        public float minutes;
        public char direction;

       
        public Angle(int degree, float minutes, char direction)
        {
            
            this.degree = degree;
            this.minutes = minutes;
            this.direction = direction;

           
        }
        public void setvalue(int d,float m,char direct)
        {
            degree = d;
            m = minutes;
            direction = direct;
        }
        public void disply()
        {
            Console.WriteLine(degree + "\u00b0" + minutes + "\u00b0" + direction);
        }
    }
}
