using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Player : ClubEmployee
    {
        public double Health;
        public double Focus;
        public double Happiness;
        public Player()
        {
            salary = 1000;
            Health = 3.8;
            Focus = 3.5;
            Happiness = 3.2;
        }

        public override double GetWeekSalary()
        {
            return salary;
        }

    }
}
