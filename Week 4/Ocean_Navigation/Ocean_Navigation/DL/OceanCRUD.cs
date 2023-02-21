using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ocean_Navigation.BL;
using Ocean_Navigation.UI;

namespace Ocean_Navigation.DL
{
    class OceanCRUD
    {
        static public List<Ship> Ships = new List<Ship>();
        static public void addShipstoLists(Ship s)
        {
            Ships.Add(s);
        }
        static public string ship_name(Angle longi,Angle lati)
        {
            foreach (Ship s in Ships)
            {
                if(s.longitude.degree==longi.degree && s.longitude.minutes==longi.minutes && s.longitude.direction==longi.direction && s.latitude.degree == lati.degree && s.latitude.minutes == lati.minutes && s.latitude.direction == lati.direction)
                {
                    return s.name;
                }
            }
            return null;
        }
    }
}
