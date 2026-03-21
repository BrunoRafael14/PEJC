using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using PEJC.Games.LeagueOfLegends.Classes;

namespace PEJC.Core
{
    public class FilesReading
    {
        private static readonly string championsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Games\LeagueOfLegends\Data\champions.json");
        private static readonly string matchHistoryFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Games\LeagueOfLegends\Data\match-history.json");


        public static string ShowFilePath(string filePath)
        {
            switch (filePath)
            {
                case "matchHistoryFilePath":
                    return matchHistoryFilePath;
                case "championsFilePath": 
                    return championsFilePath;

                default:
                    throw new ArgumentException("Arquivo não reconhecido.");
            }
        }

        public static Dictionary<string, double?> ChampionFileReading()        
        {
            string jsonContent = File.ReadAllText(championsFilePath);
            Dictionary<string, double?> champions = JsonSerializer.Deserialize<Dictionary<string, double?>>(jsonContent) ?? throw new Exception("Falha ao deserializar o JSON.");

            return champions;
        }

        public static void SerializeFile(object colection, string file)
        {
            string json = JsonSerializer.Serialize(colection, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(file, json);
        }

    }
}