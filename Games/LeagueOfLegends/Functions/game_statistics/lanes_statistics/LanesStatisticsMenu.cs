using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Core;
using PEJC.Games.LeagueOfLegends.Data;
using PEJC.Games.LeagueOfLegends.Classes;

namespace PEJC.Games.LeagueOfLegends.Functions.game_statistics.lanes_statistics
{
    public class LanesStatisticsMenu
    {

        public static void ShowLaneStatistics()
        {
            string championName = PullChampionName();
            PullChampionStatistics(championName);
        }

        public static string PullChampionName()
        {
            while (true)
            {
                Console.WriteLine("Informe o nome do Campeão que deseja puxar as estatísticas");
                string? championName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(championName) && Validations.ChampionNameChecker(championName))
                {
                    return championName;
                }
                Console.WriteLine("Dados inválidos, tente novamente");
            }
        }

        public static void PullChampionStatistics(string championName)
        {
            List<Match> matches = JsonService.PullMatchData();
            if(matches.Count == 0)
            {
                Console.WriteLine("Nenhuma Partida Registrada");
            }
            else
            {
                
            }

        }
    }
}