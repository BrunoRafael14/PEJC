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
            {"Registrar Partida", RecordsAndChanges.MatchRegistre},
            {"Registrar Maestria de Campeão", RecordsAndChanges.MaestryRegistre},
            {"Alterar Maestria de Campeão", RecordsAndChanges.MaestryChange}
        };

        public static void StartLolMenu()
        {
            IMenu.StartMenu(Options);
        }
    }
}