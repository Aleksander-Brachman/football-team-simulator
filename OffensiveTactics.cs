using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class OffensiveTactics : TacticsState
    {
        public override double ScoreGoal()
        {
            return 7.8;
        }

        public override double DefendGoal()
        {
            return 5.4;
        }
    }
}
