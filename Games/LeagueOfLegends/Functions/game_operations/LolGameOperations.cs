using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Games.LeagueOfLegends.Data;
using PEJC.Games.LeagueOfLegends.Classes;

namespace PEJC.Games.LeagueOfLegends.Functions.game_statistics
{
    public class LolGameOperations
    {
        public static void MatchRegistre()
        {
            var matchCreated = LolFactory.CreateMatch();
            JsonService.SaveMatchData(matchCreated);
        }

        public static void MasteryRegistre()
        {
            var championInitialMasteryCreated = LolFactory.DefineMastery();
            JsonService.SaveInitialMasteryData(championInitialMasteryCreated);
        }

        public static void MasteryChange()
        {
            var championMasteryChanged = LolFactory.DefineMastery();
            JsonService.ChangeInitialMasteryData(championMasteryChanged);
        }
    }
}