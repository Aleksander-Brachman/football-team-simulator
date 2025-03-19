using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.Json;
using System.IO;

namespace ZadProjekt
{
    class Simulation
    {
        
        public static void Start()
        {
            string ans;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------SYMULACJA KLUBU PIŁKARSKIEGO--------");
            Console.ResetColor();
            Console.WriteLine("Aby wybrać podaną opcję, wpisz cyfrę poniżej.");
            Console.WriteLine("1. Rozpocznij symulację");
            Console.WriteLine("2. Krótkie wprowadzenie");
            Console.WriteLine("3. Wyjdź z programu");
            Console.Write("Wybrana opcja: ");
            ans = Console.ReadLine();

            if (ans == "1")
            {
                Run();
            }
            else if (ans == "2")
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Podczas symulacji Twoim zadaniem jest przygotowanie drużyny do nadchodzącego spotkania.");
                Console.WriteLine("Od Ciebie będzie zależeć tygodniowy sposób treningu drużyny oraz taktyka podczas meczu.");
                Console.WriteLine("Wybierając intensywny trening drużyna będzie mieć lepszą koncentrację, lecz spadnie jej poziom wytrzymałości.");
                Console.WriteLine("Wybierając trening ekonomiczny drużyna w ciągu tygodnia zyska na wytrzymałości, lecz jej koncetracja spadnie.");
                Console.WriteLine("Optymalny poziom koncentracji sprzyja ofensywnej grze, a optymalny poziom wytrzymałości - grze defensywnej.");
                Console.WriteLine("Przy taktyce ofensywnej drużyna ma wysoki współczynnik prawd. strzelenia bramki, lecz słabiej broni.");
                Console.WriteLine("Przy taktyce defensywnej drużna ma wysoki współczynnik obrony przed stratą gola, jednakże słabiej atakuje.");
                Console.WriteLine("Taktyka zrównoważona stawia na balans między atakiem i obroną, jednakże nie zawsze jest to optymalne rozwiązanie.");
                Console.WriteLine("W każdym tygodniu bierz pod uwagę profil rywala oraz poziom wytrzymałości/koncentracji zespołu.");
                Console.WriteLine("Bądź ostrożny z wyborem treningu i taktyki, ponieważ w trakcie symulacji drużyna może być zmuszona do dodatkowej sesji z psychologiem/fizjoterapeutą.");
                Console.WriteLine("Takie zdarzenia są niemile widziane przez Kierownika zespołu.");
                Console.WriteLine("Po zakończeniu symulacji, Kierownik zadecyduje o tym, czy Twoimi decyzjami, spełniłeś szereg celów.");
                Console.WriteLine("Powodzenia!");
                Console.WriteLine();
                Thread.Sleep(15000);
                Start();
            }
            else if (ans == "3")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wpisz cyfrę 1, 2 lub 3.");
                Start();
            }
        }
        
        public static void Run()
        {
            ClubEmployee p1 = new Player();
            ClubEmployee p2 = new Player();
            ClubEmployee p3 = new Player();
            ClubEmployee p4 = new Player();
            ClubEmployee p5 = new Player();
            ClubEmployee p6 = new Player();
            ClubEmployee p7 = new Player();
            ClubEmployee p8 = new Player();
            ClubEmployee p9 = new Player();
            ClubEmployee p10 = new Player();
            ClubEmployee p11 = new Player();
            ClubEmployee _physio = new Physiotherapist();
            ClubEmployee _psycho = new Psychologist();
            ClubEmployee ground = new Groundsman();
            ClubEmployee coach = new Coach();
            List<ClubEmployee> clubEmployees = new List<ClubEmployee>();
            clubEmployees.Add(p1);
            clubEmployees.Add(p2);
            clubEmployees.Add(p3);
            clubEmployees.Add(p4);
            clubEmployees.Add(p5);
            clubEmployees.Add(p6);
            clubEmployees.Add(p7);
            clubEmployees.Add(p8);
            clubEmployees.Add(p9);
            clubEmployees.Add(p10);
            clubEmployees.Add(p11);
            clubEmployees.Add(_physio);
            clubEmployees.Add(_psycho);
            clubEmployees.Add(ground);
            clubEmployees.Add(coach);


            Player f1 = new Player();
            Player f2 = new Player();
            Player f3 = new Player();
            Player f4 = new Player();
            Player f5 = new Player();
            Player f6 = new Player();
            Player f7 = new Player();
            Player f8 = new Player();
            Player f9 = new Player();
            Player f10 = new Player();
            Player f11 = new Player();
            List<Player> players = new List<Player>();
            players.Add(f1);
            players.Add(f2);
            players.Add(f3);
            players.Add(f4);
            players.Add(f5);
            players.Add(f6);
            players.Add(f7);
            players.Add(f8);
            players.Add(f9);
            players.Add(f10);
            players.Add(f11);
            Psychologist psycho = new Psychologist();
            Physiotherapist physio = new Physiotherapist();

            ClubFacility _gym = new Gym();
            ClubFacility _sp = new SwimmingPool();
            ClubFacility _stadium = new Stadium();
            ClubFacility trainingGround = new TrainingGround();


            Gym gym = new Gym();
            SwimmingPool sp = new SwimmingPool();
            Stadium stadium = new Stadium();



            Training training = new Training();
            Tactics tactics = new Tactics();
            TeamParameters befMatch = new TeamParameters(players);
            Rival rival = new Rival();
            Match match = new Match(befMatch, tactics, rival);
            Sponsor sponsor = new Sponsor(match);

            AfterMatch aftMatch = new AfterMatch(match, players);
            ClubReputation clubReputation = new ClubReputation(match);
            Recovery recovery = new Recovery(players, sp, gym, physio);
            ClubStore clubStore = new ClubStore(clubReputation);
            ClubFacility _clubStore = new ClubStore(clubReputation);
            List<ClubFacility> clubFacilities = new List<ClubFacility>();
            clubFacilities.Add(_gym);
            clubFacilities.Add(_sp);
            clubFacilities.Add(_stadium);
            clubFacilities.Add(trainingGround);
            Budget budget = new Budget(clubEmployees, clubFacilities, sponsor, stadium, clubStore);
            CheckPlayers check = new CheckPlayers(befMatch, players, physio, psycho, budget);
            Statistics stats = new Statistics(match, befMatch, clubReputation, budget, psycho, physio);
            ClubOwner clubOwner = new ClubOwner(stats);
            ToJson toJson = new ToJson(stats);




            List<double> rivalScore = new List<double>();
            rivalScore.Add(6.0);
            rivalScore.Add(7.9);
            rivalScore.Add(8.2);
            rivalScore.Add(5.9);
            rivalScore.Add(6.4);
            rivalScore.Add(7.9);
            rivalScore.Add(4.1);

            List<double> rivalDefend = new List<double>();
            rivalDefend.Add(7.9);
            rivalDefend.Add(4.3);
            rivalDefend.Add(5.0);
            rivalDefend.Add(3.8);
            rivalDefend.Add(6.1);
            rivalDefend.Add(7.1);
            rivalDefend.Add(9.0);

            List<string> rivalStyles = new List<string>();
            rivalStyles.Add("Zespół skupiający się na defensywie, lecz potrafi zagrozić bramce rywala.");
            rivalStyles.Add("Zespół słaby w obronie, lecz pewny w ataku.");
            rivalStyles.Add("Drużyna bardzo ofensywna z słabą obroną.");
            rivalStyles.Add("Drużyna bez formy w ofensywie i defensywie");
            rivalStyles.Add("Zespół zrównoważony między obroną i defensywą");
            rivalStyles.Add("Drużyna w formie, mocna w ataku i obronie.");
            rivalStyles.Add("Zespół stawia autobus w polu karnym, obrona za wszelką cenę.");

            for (int k = 0; k < 7; k++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TYDZIEŃ: " + (k+1));
                Console.ResetColor();
                Console.WriteLine("Stan budżetu: " + budget.GetBudget());
                Console.WriteLine("Reputacja klubu: " + clubReputation.GetReputation());
                Console.WriteLine("");
                Console.WriteLine("Charakterystyka następnego rywala: " + rivalStyles[k]);
                Console.WriteLine("Wytrzymałość drużyny: " + befMatch.TeamHealth());
                Console.WriteLine("Koncentracja drużyny: " + befMatch.TeamFocus());
                Console.WriteLine("Morale drużyny: " + befMatch.TeamHappiness());
                Console.WriteLine("");
                training.ChooseTraining();
                training.HealthTraining(players);
                training.FocusTraining(players);
                Console.WriteLine("Drużyna trenuje...");
                Thread.Sleep(3000);
                Console.WriteLine("Wytrzymałość drużyny: " + befMatch.TeamHealth());
                Console.WriteLine("Koncentracja drużyny: " + befMatch.TeamFocus());
                tactics.ChooseTactics();
                Console.WriteLine();
                rival.Score = rivalScore[k];
                rival.Defend = rivalDefend[k];
                Console.WriteLine("Mecz jest rozgrywany...");
                match.Result();
                if (match.GetResult() == "win")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Brawo, zwycięstwo!");
                    Console.ResetColor();
                }
                else if (match.GetResult() == "draw")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Remis!");
                    Console.ResetColor();
                }
                else if (match.GetResult() == "lose")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Niestety, porażka!");
                    Console.ResetColor();
                }
                aftMatch.UpdateHealth();
                aftMatch.UpdateHappiness();
                Console.WriteLine();
                Console.WriteLine("Sprawdzanie stanu drużyny...");
                Thread.Sleep(3000);
                check.CheckHealth();
                check.CheckHappiness();
                Console.WriteLine("Regeneracja drużyny...");
                Thread.Sleep(3000);
                recovery.RecoverTeam();
                Console.WriteLine();
                Console.WriteLine("Aktualizacja reputacji klubu oraz budżetu...");
                sponsor.SponsorMoney();
                clubReputation.Reputation();
                budget.UpdateBudget();
                Console.WriteLine();
                stats.UpdateStatistics();
            }           
            clubOwner.Decision();
            toJson.ListToJson();
            Thread.Sleep(6000);
            Start();


           
        }
    }
}
