using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Physiotherapist : ClubEmployee
    {
        int time = 0;
        
        public Physiotherapist()
        {
            salary = 300;
        }

        public override double GetWeekSalary()
        {
            return salary;
        }
        public double PhysioRecovery()
        {
            return 0.1;
        }

        public double PhysioAdditionalRecovery()
        {
            return 0.4;
        }

        public int IfUsed(bool t)
        {
            if (t == true)
            {
                time += 1;
            }
            else
            {
                time += 0;
            }

            return time;
        }
        public int GetIfUsed()
        {
            return time;
        }
    }
}
