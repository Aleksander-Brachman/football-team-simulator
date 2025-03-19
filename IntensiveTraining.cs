using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class IntensiveTraining : TrainingState
    {
        double max1 = 0.55;
        double min1 = 0.45;
        double max2 = 0.35;
        double min2 = 0.25;
        Random rnd = new Random();
        public override double HealthTraining(List<Player> players)
        {
            foreach (var p in players)
            {
                p.Health -= rnd.NextDouble() * (max1 - min1) + min1;
            }  
            return players.Sum(x => x.Health) / players.Count;
        }

        public override double FocusTraining(List<Player> players)
        {
            foreach (var p in players)
            {
                p.Focus += rnd.NextDouble() * (max2 - min2) + min2;
            }
            return players.Sum(x => x.Focus) / players.Count;
        }
    }
}
