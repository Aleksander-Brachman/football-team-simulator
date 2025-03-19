using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class ClubReputation
    {
        public double reputation;
        private Match match;

        public ClubReputation(Match _match)
        {
            match = _match;
            reputation = 3.5;
        }

        public double Reputation()
        {
            if (match.GetResult() == "win")
            {
                reputation += 0.3;
            }
            else if (match.GetResult() == "draw")
            {
                reputation += 0.0;
            }
            else if (match.GetResult() == "lose")
            {
                reputation -= 0.3;
            }

            return reputation;
        }

        public double GetReputation()
        {
            return reputation;
        }
    }
}
