using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class AfterMatch
    {
        private Match match;
        private List<Player> players;
        double min1 = 0.1;
        double max1 = 0.2;

        Random rnd = new Random();

        public AfterMatch(Match _match, List<Player> _players)
        {
            match = _match;
            players = _players;
        }

        public void UpdateHappiness()
        {
            if (match.GetResult() == "win")
            {
                foreach (var p in players)
                {
                    p.Happiness += 0.2;
                }
            }
            else if (match.GetResult() == "draw")
            {
                foreach (var p in players)
                {
                    p.Happiness += 0.0;
                }
            }
            else if (match.GetResult() == "lose")
            {
                foreach (var p in players)
                {
                    p.Happiness -= 0.2;
                }
            }
        }

        public void UpdateHealth()
        {
            foreach (var p in players)
            {
                p.Health -= rnd.NextDouble() * (max1 - min1) + min1;
            }
        }
    }
}
