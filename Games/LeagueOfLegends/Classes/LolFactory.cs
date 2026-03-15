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
            champion.Name = LolMatchsInputs.GetChampion();
            champion.Mastery = LolMatchsInputs.GetMastery();

            return champion;
        }

        public static Match CreateMatch()
        {
            Match match = new Match();
            match.Kills = LolMatchsInputs.GetKills();
            match.Deaths = LolMatchsInputs.GetDeaths();
            match.Assists = LolMatchsInputs.GetAssists();
            match.PdlGained = LolMatchsInputs.GetPdl();
            match.MaestryGained = LolMatchsInputs.GetMastery();
            match.LanePlayed = LolMatchsInputs.GetLane(LanesOptions);
            match.ChampionPlayed = LolMatchsInputs.GetChampion();

            return match;
        }
    }
}