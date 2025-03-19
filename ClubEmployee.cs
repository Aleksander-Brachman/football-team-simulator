using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    abstract class ClubEmployee
    {
        protected double salary;

        public ClubEmployee()
        {
        }

        public abstract double GetWeekSalary();
        
    }
}
