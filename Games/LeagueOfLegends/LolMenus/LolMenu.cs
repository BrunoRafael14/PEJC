using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Core;
using PEJC.Games.LeagueOfLegends.Functions.game_statistics;

namespace PEJC.Games.LeagueOfLegends.LolMenus
{
    public class LolMenu
    {
        private static readonly Dictionary<string, Action> Options = new Dictionary<string, Action>
        {
            {"Registrar Partida", LolGameOperations.MatchRegistre},
            {"Registrar Maestria de Campeão", LolGameOperations.MasteryRegistre},
            {"Alterar Maestria de Campeão", LolGameOperations.MasteryChange},
            {"Visualizar Estatísticas", StatisticsDisplayMenu.StartStatisticsMenu}

        };

        public static void StartLolMenu()
        {
            CommonMenu.StartMenu(Options);
        }
    }
}