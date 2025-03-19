using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class BalancedTactics : TacticsState
    {
        public override double ScoreGoal()
        {
            return 6.4;
        }

        public override double DefendGoal()
        {
            return 6.5;
        }
    }
}
