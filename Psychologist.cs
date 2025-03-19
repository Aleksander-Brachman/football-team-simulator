using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Psychologist : ClubEmployee
    {

        private int time = 0;
        
        public Psychologist()
        {
            salary = 250;
        }

        public override double GetWeekSalary()
        {
            return salary;
        }
        
        public double RecoverHappiness()
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
