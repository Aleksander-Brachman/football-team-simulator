using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ZadProjekt
{
    class ToJson
    {
        private Statistics stats;
        private List<string> statsList;
        public ToJson(Statistics _stats)
        {
            stats = _stats;           
        }

        public void ListToJson()
        {
            statsList = new List<string>() { "Wygrane: " + stats.GetWins().ToString(), "Remisy: " + stats.GetDraws().ToString(), "Porazki: " + stats.GetDefeats().ToString(), "Morale druzyny: " + stats.GetTeamHappiness().ToString(), "Reputacja klubu: " + stats.GetClubReputation().ToString(), "Budzet klubu: " + stats.GetBudget().ToString() };
            JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };
            string statsListAsJson = JsonSerializer.Serialize(statsList, options);
            string fileName = @"C:\Users\Aleksander\source\repos\ZadProjekt\ListStats";
            File.WriteAllText(fileName, statsListAsJson);
        }
    }
}
