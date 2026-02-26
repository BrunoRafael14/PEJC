using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Core;

namespace PEJC.Games.LeagueOfLegends.Functions
{
    public class LolMatchsInputs
    {

        public static int GetKills()
        {
            Console.WriteLine("Informe quantidade de Kills: ");
            int kills = Validations.ReadIntInput();
            return kills;
        }
        
        public static int GetDeaths()
        {
            Console.WriteLine("Informe quantidade de Mortes: ");
            int deaths = Validations.ReadIntInput();
            return deaths;
        }

        public static int GetAssists()
        {
            Console.WriteLine("Informe quantidade de Assistências: ");
            int assists = Validations.ReadIntInput();
            return assists;
        }

        public static int GetPdl()
        {
            Console.WriteLine("Informe quantidade de PDL: ");
            int pdl = Validations.ReadIntInput();
            return pdl;
        }

        public static int GetMastery()
        {
            Console.WriteLine("Informe quantidade de Maestria: ");
            int masteryMatch = Validations.ReadIntInput();
            return masteryMatch;
        }

        public static string GetLane(List<string> LanesOptions)
        {
            while (true)
            {
                Console.WriteLine("Informe a Lane (Toplane, Midlane, Jungle, Atirador, Suporte): ");
                string? lanePlayed = Console.ReadLine();
                if(!string.IsNullOrWhiteSpace(lanePlayed) && Validations.LaneNameChecker(LanesOptions, lanePlayed))
                {
                    return lanePlayed;
                }
                Console.WriteLine("Dados inválidos, tente novamente");
            }
        }

        public static string GetChampion()
        {
            while(true)
            {
                Console.WriteLine("Informe Nome do Campeão: ");
                string? champion = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(champion) && Validations.ChampionNameChecker(champion))
                {
                    return champion;
                }
                Console.WriteLine("Dados inválidos, tente novamente");
            }
        }
    }
}