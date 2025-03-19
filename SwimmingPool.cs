using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class SwimmingPool : ClubFacility
    {
        public SwimmingPool()
        {
            upkeep = 170;
        }

        public override double GetWeekUpkeep()
        {
            return upkeep;
        }

        public double SPRecovery()
        {
            return 0.1;
        }
    }
}
