using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Training
    {
        public TrainingState State = new IntensiveTraining();

        public void ChooseTraining()
        {
            Console.WriteLine("Wybierz trening, wpisując 1 lub 2");
            Console.WriteLine("1. Intensywny, 2. Ekonomiczny");
            string ans = Console.ReadLine();
            if (ans == "1")
            {
                State = new IntensiveTraining();
                Console.WriteLine("Wybrałeś intensywny trening.");
            }
            else if (ans == "2")
            {
                State = new EconomicalTraining();
                Console.WriteLine("Wybrałeś ekonomiczny trening");
            }
            else
            {
                Console.WriteLine("Wpisz 1 lub 2.");
                ChooseTraining();
            }
        }

        public void HealthTraining(List<Player> players)
        {
            State.HealthTraining(players);
        }

        public void FocusTraining(List<Player> players)
        {
            State.FocusTraining(players);
        }
    }
}
