using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Core;

namespace PEJC.Games.LeagueOfLegends.Functions
{
    public class ILolCreateMatch
    {

        public static int GetKills()
        {
            Console.WriteLine("Informe quantidade de Kills: ");
            int killsMatch = Validations.ReadIntInput();
            return killsMatch;
        }
        
        public static int GetDeaths()
        {
            Console.WriteLine("Informe quantidade de Mortes: ");
            int deathsMatch = Validations.ReadIntInput();
            return deathsMatch;
        }

        public static int GetAssists()
        {
            Console.WriteLine("Informe quantidade de Assistências: ");
            int assistsMatch = Validations.ReadIntInput();
            return assistsMatch;
        }

        public static int GetPdlGained()
        {
            Console.WriteLine("Informe quantidade de PDL Ganho: ");
            int pdlGainedMatch = Validations.ReadIntInput();
            return pdlGainedMatch;
        }

        public static int GetMaestryGained()
        {
            Console.WriteLine("Informe quantidade de Maestria Ganha: ");
            int maestryGainedMatch = Validations.ReadIntInput();
            return maestryGainedMatch;
        }

        public static string GetLanePlayed(List<string> LanesOptions)
        {
            while (true)
            {
                Console.WriteLine("Informe a Lane Jogada (Toplane, Midlane, Jungle, Atirador, Suporte): ");
                string? lanePlayedMatch = Console.ReadLine();
                if(!string.IsNullOrWhiteSpace(lanePlayedMatch) && Validations.LaneNameChecker(LanesOptions, lanePlayedMatch))
                {
                    return lanePlayedMatch;
                }
                Console.WriteLine("Dados inválidos, tente novamente");
            }
        }

        public static string GetChampionPlayed()
        {
            while(true)
            {
                Console.WriteLine("Informe Nome do Campeão utilizado: ");
                string? championPlayedMatch = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(championPlayedMatch) && Validations.ChampionNameChecker(championPlayedMatch))
                {
                    return championPlayedMatch;
                }
                Console.WriteLine("Dados inválidos, tente novamente");
            }
        }
    }
}