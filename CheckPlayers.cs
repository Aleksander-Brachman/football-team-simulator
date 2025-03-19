using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class CheckPlayers
    {
        private List<Player> players;
        private TeamParameters parameters;
        private Physiotherapist physo;
        private Psychologist psycho;
        private Budget b;
        //private double teamHealth;
       // private double teamHappiness;
        bool used = true;

        public CheckPlayers(TeamParameters _parameters, List<Player> _players, Physiotherapist _physo, Psychologist _psycho, Budget _b)
        {
            players = _players;
            parameters = _parameters;
            physo = _physo;
            psycho = _psycho;
            b = _b;
        }

        public void CheckHappiness()
        {
            //teamHappiness = players.Sum(x => x.Happiness) / players.Count;

            if (parameters.TeamHappiness() < 2.75)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Morale drużyny zbyt niskie, potrzebna konsultacja z psychologiem");
                Console.ResetColor();
                foreach (var p in players)
                {
                    p.Happiness += psycho.RecoverHappiness();
                }
                b.ClubBudget -= 1000.0;
                psycho.IfUsed(used);
            }
            else
            {
                Console.WriteLine("Morale drużyny są na akceptowalnym poziomie.");
                return;
            }
        }
        public void CheckHealth()
        {
            //teamHealth = players.Sum(x => x.Health) / players.Count;

            if (parameters.TeamHealth() < 2.55)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Drużyna jest przemęczona, potrzebne dodatkowe zajęcia z fizjoterapeutą.");
                Console.ResetColor();
                foreach (var p in players)
                {
                    p.Health += physo.PhysioAdditionalRecovery();
                }
                b.ClubBudget -= 2000.0;
                physo.IfUsed(used);
            }
            else
            {
                Console.WriteLine("Drużyna nie jest przemęczona");
                return;
            }
        }
    }
}
