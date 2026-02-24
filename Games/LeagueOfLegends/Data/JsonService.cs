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
        public static void SaveMatchData(Match matchCreated)
        {
            
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Games\LeagueOfLegends\Data\match-history.json");
            List<Match> matches = new List<Match>();

            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    matches = JsonSerializer.Deserialize<List<Match>>(existingJson) ?? new List<Match>();
                }
            }

            matches.Add(matchCreated);

            string json = JsonSerializer.Serialize(matches, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}