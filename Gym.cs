using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Gym : ClubFacility
    {
        public Gym()
        {
            upkeep = 150;
        }

        public override double GetWeekUpkeep()
        {
            return upkeep;
        }

        public double GymRecovery()
        {
            return 0.1;
        }
    }
}
