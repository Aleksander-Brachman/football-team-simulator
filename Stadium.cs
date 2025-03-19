using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Stadium : ClubFacility
    {
        private int maxCapacity;
        Random rnd = new Random();
        public Stadium()
        {
            upkeep = 800;
            maxCapacity = 10000;
        }

        public override double GetWeekUpkeep()
        {
            return upkeep;
        }

        public double GetCapacity()
        {           
            return rnd.Next(8000, maxCapacity);
        }
    }
}
