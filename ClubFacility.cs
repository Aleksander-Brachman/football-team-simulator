using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    abstract class ClubFacility
    {
        protected double upkeep;

        public ClubFacility()
        {
            upkeep = 100;
        }

        public abstract double GetWeekUpkeep();
        
    }
}
