using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class DefensiveTactics : TacticsState
    {
        public override double ScoreGoal()
        {
            return 4.9;
        }

        public override double DefendGoal()
        {
            return 8.0;
        }
    }
}
