using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Core;

namespace PEJC.Games.LeagueOfLegends.Classes
{
    public class LolFactory
    {
        private static readonly List<string> LanesOptions = new List<string>
        {"Toplane", "Midlane", "Jungle", "Atirador", "Suporte"};
        public static Champion CreateChampion()
        {
            Console.WriteLine("Digite o nome do Campeão: ");
            string? championName= Console.ReadLine();
            Console.WriteLine("Digite a quantidade Total de Maestria com o Campeão: ");
            double championMaestry = Convert.ToDouble(Console.ReadLine());

            Champion champion = new Champion();
            champion.Name = championName;
            champion.Maestry = championMaestry;


            return champion;
        }

        public static Match CreateMatch()
        {
            Match match = new Match();
            match.Kills = ILolCreateMatch.GetKills();
            match.Deaths = ILolCreateMatch.GetDeaths();
            match.Assists = ILolCreateMatch.GetAssists();
            match.PdlGained = ILolCreateMatch.GetPdlGained();
            match.MaestryGained = ILolCreateMatch.GetMaestryGained();
            match.LanePlayed = ILolCreateMatch.GetLanePlayed(LanesOptions);
            match.ChampionPlayed = ILolCreateMatch.GetChampionPlayed();

            return match;
        }
    }
}