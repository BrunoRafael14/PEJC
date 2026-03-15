using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Games.LeagueOfLegends.LolMenu;
using PEJC.Core;

namespace PEJC.HomeMenu
{
    public class HomeMenu
    {
        private static readonly Dictionary<string, Action> GameOptions = new Dictionary<string, Action>
        {
            {"League of Legends", LolMenu.StartLolMenu}
        };

        public static void StartHomeMenu()
        {
            CommonMenu.StartMenu(GameOptions);
        }
    }
}