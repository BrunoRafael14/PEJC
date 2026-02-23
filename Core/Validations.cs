using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace PEJC.Core
{
    public class Validations
    {
        public const int IndexCorrection = 1;

        public static int ReadIntInput()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Opção Inválida, digite um número.");
            }
            return value;
        }

        public static bool MenuChoiceFilter(bool validationStatusLoop, int response, Dictionary<string, Action> options)
        {
            
            if (response > (options.Count + IndexCorrection) || response < IndexCorrection)
            {
                Console.WriteLine("Opção Inválida");
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ChampionNameChecker(string championPlayedMatch)
        {
            string jsonPath = "Games/LeagueOfLegends/Data/chapions.json";
            string? jsonContent = File.ReadAllText(jsonPath);
            Dictionary<string, object?> champions = JsonSerializer.Deserialize<Dictionary<string, object?>>(jsonContent)?? throw new Exception("Falha ao deserializar o JSON.");

            return champions.ContainsKey(championPlayedMatch);
        }

        public static bool LaneNameChecker(List<string> LanesOptions, string lanePlayedMatch)
        {

            return LanesOptions.Contains(lanePlayedMatch);
        
        }
    }
}