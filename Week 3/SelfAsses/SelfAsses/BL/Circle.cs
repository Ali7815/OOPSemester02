using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAsses.BL
{
    class Circle
    {
        public float raduis;
        public float area()
        {
            float area1 = (raduis * raduis);
            area1 = 3.14F * area1;
            return area1;
        }
        public float diameter()
        {
            float dia = raduis * 2;
            return dia;
        }
        public float circumference()
        {
            float circum = 2 * 3.14F * raduis;
            return circum;
        }
    }
}
