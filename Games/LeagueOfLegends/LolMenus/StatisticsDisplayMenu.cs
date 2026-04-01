using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Core;
using PEJC.Games.LeagueOfLegends.Functions.game_statistics;
using PEJC.Games.LeagueOfLegends.Functions.game_statistics.champions_statistics;
using PEJC.Games.LeagueOfLegends.Functions.game_statistics.matches_statistics;
using PEJC.Games.LeagueOfLegends.Functions.game_statistics.ranking_statistics;
using PEJC.Games.LeagueOfLegends.Functions.game_statistics.lanes_statistics;

namespace PEJC.Games.LeagueOfLegends.LolMenus
{
    public class StatisticsDisplayMenu
    {
        private static readonly Dictionary<string, Action> Options = new Dictionary<string, Action>
        {
            //{"Vizualizar Partidas", MatchesStatisticsMenu.MatchRegistre},
            //{"Vizualizar Rankings", RankingStatisticsMenu.MasteryRegistre},
            // {"Vizualizar Campeões", ChampionsStatisticsMenu.MasteryChange},
            {"Visualizar Lanes", LanesStatisticsMenu.ShowLaneStatistics}
        };

        public static void StartStatisticsMenu()
        {
            CommonMenu.StartMenu(Options);
        }
    }
}