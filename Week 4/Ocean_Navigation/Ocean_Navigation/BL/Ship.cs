using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.BL
{
    class Ship
    {
        public string name;
        public Angle latitude;
        public Angle longitude;

        public Ship(string name,Angle longitude,Angle latitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public Ship(Angle longitude, Angle latitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
