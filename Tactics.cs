using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Tactics
    {
        public TacticsState State;

        public void ChooseTactics()
        {          
            Console.WriteLine("Wybierz taktykę, wpisując 1, 2 lub 3");
            Console.WriteLine("1 - ofensywna, 2 - defensywna, 3 - zrównoważona");
            Console.Write("Wybór: ");
            string ans = Console.ReadLine();
                if (ans == "1")
                {
                    State = new OffensiveTactics();
                    Console.WriteLine("Wybrałeś ofensywną taktykę.");
                }
                else if (ans == "2")
                {
                    State = new DefensiveTactics();
                    Console.WriteLine("Wybrałeś defensywną taktykę.");
                }
                else if (ans == "3")
            {
                State = new BalancedTactics();
                Console.WriteLine("Wybrałeś zrównoważoną taktykę.");
            }
                else
            {
                Console.WriteLine("Wpisz 1, 2 lub 3.");
                ChooseTactics();
            }
        }

        public double ScoreGoal()
        {
            return State.ScoreGoal();
        }

        public double DefendGoal()
        {
            return State.DefendGoal();
        }
    }
}
