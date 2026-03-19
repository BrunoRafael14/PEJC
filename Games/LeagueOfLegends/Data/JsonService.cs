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

        // Métodos de Funcinomento
        private static readonly string championsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Games\LeagueOfLegends\Data\champions.json");
        private static readonly string matchHistoryFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Games\LeagueOfLegends\Data\match-history.json");

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

        public static void UpdateData(Champion champion)
        {
            var champions = ChampionFileReading();
            champions[champion.Name!] = champion.Mastery;

            SerializeFile(champions, championsFilePath);
        }

        // Métodos de Save
        public static void SaveMatchData(Match matchCreated)
        {
            List<Match> matches = new List<Match>();

            if (File.Exists(matchHistoryFilePath))
            {
                string existingJson = File.ReadAllText(matchHistoryFilePath);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    matches = JsonSerializer.Deserialize<List<Match>>(existingJson) ?? new List<Match>();
                }
            }

            matches.Add(matchCreated);
            SerializeFile(matches, matchHistoryFilePath);
        }

        public static void SaveInitialMasteryData(Champion champion)
        {

            if (ChampionFileReading()[champion.Name!] != null)
            {
                Console.WriteLine($"{champion.Name} já possui maestria cadastrada. Utilize a opção de alterar maestria.");
                return;
            }

            UpdateData(champion);
            Console.WriteLine($"Maestria de {champion.Name} Cadastrada com Sucesso");
        }

        public static void ChangeInitialMasteryData(Champion champion)
        {
            if (ChampionFileReading()[champion.Name!] == null)
            {
                Console.WriteLine($"{champion.Name} ainda não possui maestria cadastrada, por favor, utilize a opção de cadastrar maestria.");
                return;
            }

            UpdateData(champion);
            Console.WriteLine($"Maestria de {champion.Name} alterada com Sucesso");
        }
    }
}