using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using PEJC.Games.LeagueOfLegends.Classes;
using System.Threading.Channels;

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

        public static void SaveInitialMasteryData(Champion champion)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Games\LeagueOfLegends\Data\champions.json");
            string jsonContent = File.ReadAllText(filePath);
            Dictionary<string, double?> champions = JsonSerializer.Deserialize<Dictionary<string, double?>>(jsonContent) ?? throw new Exception("Falha ao deserializar o JSON.");

            if (!champions.ContainsKey(champion.Name!))
            {
                Console.WriteLine("Campeão não encontrado");
                return;
            }

            if (champions[champion.Name!] != null)
            {
                Console.WriteLine($"{champion.Name} já possui maestria cadastrada. Utilize a opção de alterar maestria.");
                return;
            }

            champions[champion.Name!] = champion.Mastery;

            string json = JsonSerializer.Serialize(champions, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            Console.WriteLine($"Maestria de {champion.Name} Cadastrada com Sucesso");
        }
    }
}