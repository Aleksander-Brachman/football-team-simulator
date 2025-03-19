using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class TrainingGround : ClubFacility
    {
        public TrainingGround()
        {
            upkeep = 150;
        }

        public override double GetWeekUpkeep()
        {
            return upkeep;
        }
    }
}
