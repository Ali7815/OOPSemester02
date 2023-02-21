using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTruck.BL
{
    class HousePipe
    {
        private string material;
        private string shape;
        private float diameter;
        private float flowRate;
        public HousePipe(string material,string shape,float diameter,float flowRate)
        {
            this.material = material;
            this.shape = shape;
            this.diameter = diameter;
            this.flowRate = flowRate;
        }
    }
}
