using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class ClubOwner
    {
        private Statistics stats;

        public ClubOwner(Statistics _stats)
        {
            stats = _stats;
        }

        public void Decision()
        {
            if (stats.GetWins() >= 3 && stats.GetClubReputation() >= 3.2 && stats.GetBudget() >= 95000.0 && stats.GetPhysioUsed() <= 2 && stats.GetPsychoUsed() <= 1 && stats.GetTeamHappiness() >= 3.0)
            {
                Console.WriteLine("Prezes klubu: Gratulacje, podołałeś wyzwaniu! Spełniłeś wszystkie cele, które Tobie założyłem.");
                Console.WriteLine("Wymagana min. liczba zwycięstw: 3 \t Twój wynik: " + stats.GetWins());
                Console.WriteLine("Wymagana min. morale zespołu: 3.0 \t Twój wynik: " + stats.GetTeamHappiness());
                Console.WriteLine("Wymagana min. reputacja klubu: 3.2 \t Twój wynik: " + stats.GetClubReputation());
                Console.WriteLine("Wymagany min. stan budżetu: 100 000 \t Twój wynik: " + stats.GetBudget());
                Console.WriteLine("Max. liczba dodatkowych zajęć z fizjoterapeutą: 2 \t Twój wynik: " + stats.GetPhysioUsed());
                Console.WriteLine("Max. liczba dodatkowych zajęć z psychologiem: 1 \t Twój wynik: " + stats.GetPsychoUsed());
                Console.WriteLine("");
                Console.WriteLine("Twoje wyniki zostały również zapisane w specjalnym pliku.");
            }
            else
            {
                Console.WriteLine("Prezes klubu: Niestety, nie zdałeś egzaminu! Nie wszystkie cele, które Tobie założyłem, zostały spełnione.");               
                Console.WriteLine("Wymagana min. liczba zwycięstw: 3 \t Twój wynik: " + stats.GetWins());
                Console.WriteLine("Wymagana min. morale zespołu: 3.0 \t Twój wynik: " + stats.GetTeamHappiness());
                Console.WriteLine("Wymagana min. reputacja klubu: 3.2 \t Twój wynik: " + stats.GetClubReputation());
                Console.WriteLine("Wymagany min. stan budżetu: 100 000 \t Twój wynik: " + stats.GetBudget());
                Console.WriteLine("Max. liczba dodatkowych zajęć z fizjoterapeutą: 2 \t Twój wynik: " + stats.GetPhysioUsed());
                Console.WriteLine("Max. liczba dodatkowych zajęć z psychologiem: 1 \t Twój wynik: " + stats.GetPsychoUsed());
                Console.WriteLine("");
                Console.WriteLine("Twoje wyniki zostały również zapisane w specjalnym pliku.");
            }
        }
    }
}
