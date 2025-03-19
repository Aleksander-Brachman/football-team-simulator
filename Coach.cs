using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Coach : ClubEmployee
    {
        public Coach()
        {
            salary = 800;
        }

        public override double GetWeekSalary()
        {
            return salary;
        }

        
    }
}
