using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class ClubStore : ClubFacility
    {
        Random rnd = new Random();
        private ClubReputation clr;
        private int income;
        public ClubStore(ClubReputation _clr)
        {
            clr = _clr;
            upkeep = 400;
        }

        public override double GetWeekUpkeep()
        {
            return upkeep;
        }

        public int StoreIncome()
        {
            if (clr.GetReputation() >= 4.2)
            {
                income = rnd.Next(5000, 6000);
            }
            else if (clr.GetReputation() < 4.2 && clr.GetReputation() >= 3.5)
            {
                income = rnd.Next(3500, 4500);
                
            }
            else if (clr.GetReputation() < 3.5 && clr.GetReputation() >= 2.9)
            {
                income = rnd.Next(2000, 2800);
            }
            else if (clr.GetReputation() < 2.9)
            {
                income = rnd.Next(1000, 1500);
            }

            return income;
        }

        
    }
}
