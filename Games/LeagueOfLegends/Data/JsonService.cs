using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using PEJC.Games.LeagueOfLegends.Classes;
using System.Threading.Channels;
using PEJC.Core;

namespace PEJC.Games.LeagueOfLegends.Data
{
    public class JsonService
    {

        // Métodos de Funcinomento
        public static void UpdateData(Champion champion)
        {
            var champions = FilesReading.ChampionFileReading();
            champions[champion.Name!] = champion.Mastery;

            FilesReading.SerializeFile(champions, FilesReading.ShowFilePath("championsFilePath"));
        }



        // Métodos de Save
        public static void SaveMatchData(Match matchCreated)
        {
            List<Match> matches = new List<Match>();

            if (File.Exists(FilesReading.ShowFilePath("matchHistoryFilePath")))
            {
                string existingJson = File.ReadAllText(FilesReading.ShowFilePath("matchHistoryFilePath"));
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    matches = JsonSerializer.Deserialize<List<Match>>(existingJson) ?? new List<Match>();
                }
            }

            matches.Add(matchCreated);
            FilesReading.SerializeFile(matches, FilesReading.ShowFilePath("matchHistoryFilePath"));
        }

        public static void SaveInitialMasteryData(Champion champion)
        {

            if (FilesReading.ChampionFileReading()[champion.Name!] != null)
            {
                Console.WriteLine($"{champion.Name} já possui maestria cadastrada. Utilize a opção de alterar maestria.");
                return;
            }

            UpdateData(champion);
            Console.WriteLine($"Maestria de {champion.Name} Cadastrada com Sucesso");
        }

        public static void ChangeInitialMasteryData(Champion champion)
        {
            if (FilesReading.ChampionFileReading()[champion.Name!] == null)
            {
                Console.WriteLine($"{champion.Name} ainda não possui maestria cadastrada, por favor, utilize a opção de cadastrar maestria.");
                return;
            }

            UpdateData(champion);
            Console.WriteLine($"Maestria de {champion.Name} alterada com Sucesso");
        }
    }
}