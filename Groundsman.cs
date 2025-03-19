using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Groundsman : ClubEmployee
    {
        public Groundsman()
        {
            salary = 200;
        }

        public override double GetWeekSalary()
        {
            return salary;
        }
    }
}
