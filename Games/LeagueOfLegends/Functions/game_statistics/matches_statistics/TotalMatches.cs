using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Core;
using PEJC.Games.LeagueOfLegends.Data;
using PEJC.Games.LeagueOfLegends.Classes;

namespace PEJC.Games.LeagueOfLegends.Functions.game_statistics
{
    public class TotalMatches
    {
        public static void ShowTotalMatches()
        {
            List<Match> matches = JsonService.PullMatchData();
            if(matches.Count == 0)
            {
                Console.WriteLine("Nenhuma Partida Registrada");
            }
            else
            {
                foreach(var match in matches)
                {
                    Console.WriteLine($@"
                    Kills: {match.Kills}
                    Mortes: {match.Deaths}
                    Assistências: {match.Assists}
                    PDL Ganho: {match.PdlGained}
                    Maestria Ganha: {match.MaestryGained}
                    Lane Jogada: {match.LanePlayed}
                    Campeão Jogado: {match.ChampionPlayed}
                    -------------------------");
                }
            }
        }
    }
}