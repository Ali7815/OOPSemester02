using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireTruck.BL
{
    class FireTruck2
    {
        private Ladder L;
        private HousePipe H;
        private FireFighter F;
        public FireTruck2(HousePipe H , FireFighter F)
        {
            L = new Ladder(35, "Black");
            this.H = H;
            this.F = F;
        }
    }
}
