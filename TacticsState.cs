using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    abstract class TacticsState
    {
        public abstract double ScoreGoal();
        public abstract double DefendGoal();
    }
}
