using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using PEJC.Games.LeagueOfLegends.Classes;

namespace PEJC.Games.LeagueOfLegends.Data
{
    public class JsonService
    {
        public static void SaveMatchData()
        {
            var matchCreated = LolFactory.CreateMatch();
            string filePath = "match-history.json";

            string json = JsonSerializer.Serialize(matchCreated);
            File.WriteAllText(filePath, json);
        }
    }
}