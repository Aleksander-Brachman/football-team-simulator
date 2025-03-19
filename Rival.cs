using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Rival
    {
        public double Defend;
        public double Score;
        public Rival()
        {
            Defend = 5.0;
            Score = 5.0;
        }


        public double ScoreGoal()
        {
            return Score;
        }

        public double DefendGoal()
        {
            return Defend;
        }
    }
}
