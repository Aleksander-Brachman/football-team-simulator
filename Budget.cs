using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Budget
    {
        public double ClubBudget;
        private List<ClubEmployee> clubEmployees;
        private List<ClubFacility> clubFacilities;
        private Sponsor sponsor;
        private Stadium stadium;
        private ClubStore clubStore;

        public Budget(List<ClubEmployee> _clubEmployees, List<ClubFacility> _clubFacilities, Sponsor _sponsor, Stadium _stadium, ClubStore _clubStore)
        {
            clubEmployees = _clubEmployees;
            clubFacilities = _clubFacilities;
            sponsor = _sponsor;
            stadium = _stadium;
            clubStore = _clubStore;
            ClubBudget = 100000;
        }
        public void UpdateBudget()
        {
            foreach (var em in clubEmployees)
            {
                ClubBudget -= em.GetWeekSalary();
            }
            foreach(var f in clubFacilities)
            {
                ClubBudget -= f.GetWeekUpkeep();
            }
            ClubBudget += sponsor.GetSponsorMoney();
            ClubBudget += clubStore.StoreIncome();
            ClubBudget += (stadium.GetCapacity() * 0.2);
            
        }

        public double GetBudget()
        {
            return ClubBudget;
        }
    }
}
