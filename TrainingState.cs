using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    abstract class TrainingState
    {
        public abstract double HealthTraining(List<Player> players);
        public abstract double FocusTraining(List<Player> players);
    }
}
