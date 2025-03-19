using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Statistics
    {
        private Match match;
        private TeamParameters parameters;
        private ClubReputation reputation;
        private Budget budget;
        private Psychologist psycho;
        private Physiotherapist physio;

        int wins = 0;
        int draws = 0;
        int defeats = 0;
        private double teamHealth;
        private double teamFocus;
        private double teamHappiness;
        private double clubReputation;
        private double clubBudget;
        private int psychoUsed;
        private int physioUsed;

        public Statistics(Match _match, TeamParameters _parameters, ClubReputation _reputation, Budget _budget, Psychologist _psycho, Physiotherapist _pyhsio)
        {
            match = _match;
            parameters = _parameters;
            reputation = _reputation;
            budget = _budget;
            psycho = _psycho;
            physio = _pyhsio;
            
        }

        public void UpdateStatistics()
        {           
                if (match.GetResult() == "win")
                {
                wins += 1;
                }
                else if (match.GetResult() == "draw")
                {
                    draws += 1;
                }
                else if (match.GetResult() == "lose")
                {
                    defeats += 1;
                }
            teamHealth = parameters.TeamHealth();
            teamFocus = parameters.TeamFocus();
            teamHappiness = parameters.TeamHappiness();
            clubReputation = reputation.GetReputation();
            clubBudget = budget.GetBudget();
            psychoUsed = psycho.GetIfUsed();
            physioUsed = physio.GetIfUsed();
        }

        
        public int GetWins()
        {
            return wins;
        }
        public int GetDraws()
        {
            return draws;
        }
        public int GetDefeats()
        {
            return defeats;
        }
        public double GetClubReputation()
        {
            return clubReputation;
        }
        public double GetBudget()
        {
            return clubBudget;
        }
        public double GetTeamHappiness()
        {
            return teamHappiness;
        }
        public int GetPsychoUsed()
        {
            return psychoUsed;
        }
        public int GetPhysioUsed()
        {
            return physioUsed;
        }
    }
}
