using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Core;
using PEJC.Games.LeagueOfLegends.Functions;

namespace PEJC.Games.LeagueOfLegends.Classes
{
    public class LolFactory
    {
        private static readonly List<string> LanesOptions = new List<string>
        {"Toplane", "Midlane", "Jungle", "Atirador", "Suporte"};

        public static Champion DefineMastery()
        {
            Champion champion = new Champion();
            champion.Name = LolInputs.GetChampion();
            champion.Mastery = LolInputs.GetMastery();

            return champion;
        }

        public static Match CreateMatch()
        {
            Match match = new Match();
            match.Kills = LolInputs.GetKills();
            match.Deaths = LolInputs.GetDeaths();
            match.Assists = LolInputs.GetAssists();
            match.PdlGained = LolInputs.GetPdl();
            match.MaestryGained = LolInputs.GetMastery();
            match.LanePlayed = LolInputs.GetLane(LanesOptions);
            match.ChampionPlayed = LolInputs.GetChampion();

            return match;
        }
    }
}