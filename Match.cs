using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Match
    {
        Random r = new Random();
        private TeamParameters team;
        private Tactics tactics;
        private Rival rival;
        private int goal;
        private string result;
        public Match(TeamParameters _team, Tactics _tactics, Rival _rival)
        {
            team = _team;
            tactics = _tactics;
            rival = _rival;
        }

        public string Result()
        {
            goal = r.Next(0, 100);
            if (tactics.ScoreGoal() > rival.DefendGoal() && tactics.DefendGoal() > rival.ScoreGoal())
            {
                if (team.TeamFocus() > 2.61 && team.TeamHealth() > 2.61)
                {
                    if (goal <= 85)
                    {
                        result = "win";
                    }
                    else if (goal > 85 && goal <= 95)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }

                }
                else if (team.TeamFocus() < 2.61 && team.TeamHealth() > 2.61)
                {
                    if (goal <= 75)
                    {
                        result = "win";
                    }
                    else if (goal > 75 && goal <= 85)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
                else if (team.TeamFocus() > 2.61 && team.TeamHealth() < 2.61)
                {
                    if (goal <= 80)
                    {
                        result = "win";
                    }
                    else if (goal > 80 && goal <= 90)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
                else if (team.TeamFocus() < 2.61 && team.TeamHealth() < 2.61)
                {
                    if (goal <= 70)
                    {
                        result = "win";
                    }
                    else if (goal > 70 && goal <= 85)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
            }
            else if (tactics.ScoreGoal() > rival.DefendGoal() && tactics.DefendGoal() < rival.ScoreGoal())
            {
                if (team.TeamFocus() > 2.61 && team.TeamHealth() > 2.61)
                {
                    if (goal <= 65)
                    {
                        result = "win";
                    }
                    else if (goal > 65 && goal <= 80)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }

                }
                else if (team.TeamFocus() < 2.61 && team.TeamHealth() > 2.61)
                {
                    if (goal <= 45)
                    {
                        result = "win";
                    }
                    else if (goal > 45 && goal <= 75)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
                else if (team.TeamFocus() > 2.61 && team.TeamHealth() < 2.61)
                {
                    if (goal <= 55)
                    {
                        result = "win";
                    }
                    else if (goal > 55 && goal <= 80)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
                else if (team.TeamFocus() < 2.61 && team.TeamHealth() < 2.61)
                {
                    if (goal <= 35)
                    {
                        result = "win";
                    }
                    else if (goal > 35 && goal <= 65)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
            }
            else if (tactics.ScoreGoal() < rival.DefendGoal() && tactics.DefendGoal() > rival.ScoreGoal())
            {
                if (team.TeamFocus() > 2.61 && team.TeamHealth() > 2.61)
                {
                    if (goal <= 60)
                    {
                        result = "win";
                    }
                    else if (goal > 60 && goal <= 80)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }

                }
                else if (team.TeamFocus() < 2.61 && team.TeamHealth() > 2.61)
                {
                    if (goal <= 40)
                    {
                        result = "win";
                    }
                    else if (goal > 40 && goal <= 70)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
                else if (team.TeamFocus() > 2.61 && team.TeamHealth() < 2.61)
                {
                    if (goal <= 30)
                    {
                        result = "win";
                    }
                    else if (goal > 30 && goal <= 60)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
                else if (team.TeamFocus() < 2.61 && team.TeamHealth() < 2.61)
                {
                    if (goal <= 30)
                    {
                        result = "win";
                    }
                    else if (goal > 30 && goal <= 50)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
            }
            else if (tactics.ScoreGoal() < rival.DefendGoal() && tactics.DefendGoal() < rival.ScoreGoal())
            {
                if (team.TeamFocus() > 2.61 && team.TeamHealth() > 2.61)
                {
                    if (goal <= 20)
                    {
                        result = "win";
                    }
                    else if (goal > 20 && goal <= 35)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }

                }
                else if (team.TeamFocus() < 2.61 && team.TeamHealth() > 2.61)
                {
                    if (goal <= 15)
                    {
                        result = "win";
                    }
                    else if (goal > 15 && goal <= 25)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
                else if (team.TeamFocus() > 2.61 && team.TeamHealth() < 2.61)
                {
                    if (goal <= 10)
                    {
                        result = "win";
                    }
                    else if (goal > 10 && goal <= 20)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
                else if (team.TeamFocus() < 2.61 && team.TeamHealth() < 2.61)
                {
                    if (goal <= 5)
                    {
                        result = "win";
                    }
                    else if (goal > 5 && goal <= 10)
                    {
                        result = "draw";
                    }
                    else
                    {
                        result = "lose";
                    }
                }
            }

            return result;
        }

        public string GetResult()
        {
            return result;
        }
    }
}
