using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Sponsor
    {
        private Match match;
        private double money;
        public Sponsor(Match _match)
        {
            match = _match;
            money = 4000;
        }

        public void SponsorMoney()
        {
            if (match.GetResult() == "win")
            {
                money = 15000;
            }
            else if (match.GetResult() == "draw")
            {
                money = 10000;
            }
            else if (match.GetResult() == "lose")
            {
                money = 6500;
            }       
        }

        public double GetSponsorMoney()
        {
            return money;
        }
    }
}
