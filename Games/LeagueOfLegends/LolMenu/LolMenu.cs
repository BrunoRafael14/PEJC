using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Core;
using PEJC.Games.LeagueOfLegends.Functions;

namespace PEJC.Games.LeagueOfLegends.LolMenu
{
    public class LolMenu
    {
        private static readonly Dictionary<string, Action> Options = new Dictionary<string, Action>
        {
            {"Registrar Partida", OptionsForGame.MatchRegistre},
            {"Registrar Maestria de Campeão", OptionsForGame.MasteryRegistre},
            {"Alterar Maestria de Campeão", OptionsForGame.MasteryChange}
        };

        public static void StartLolMenu()
        {
            CommonMenu.StartMenu(Options);
        }
    }
}