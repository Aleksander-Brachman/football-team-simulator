using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class TeamParameters
    {
        private List<Player> players;
        private double teamFocus;
        private double teamHealth;
        private double teamHappiness;

        public TeamParameters(List<Player> _players)
        {
            players = _players;
        }

        public double TeamFocus()
        {
            foreach (var p in players)
            {
                teamFocus = players.Sum(x => x.Focus) / players.Count;
            }
            return teamFocus;
        }

        public double TeamHealth()
        {
            foreach (var p in players)
            {
                teamHealth = players.Sum(x => x.Health) / players.Count;
            }
            return teamHealth;
        }
        public double TeamHappiness()
        {
            foreach (var p in players)
            {
                teamHappiness = players.Sum(x => x.Happiness) / players.Count;
            }
            return teamHappiness;
        }
    }
}
