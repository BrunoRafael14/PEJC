using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Games.LeagueOfLegends.Data;
using PEJC.Games.LeagueOfLegends.Classes;

namespace PEJC.Games.LeagueOfLegends.Functions
{
    public class RecordsAndChanges
    {
        public static void MatchRegistre()
        {
            var matchCreated = LolFactory.CreateMatch();
            JsonService.SaveMatchData(matchCreated);
        }

        public static void MaestryRegistre()
        {
            Console.WriteLine("Maestria Registrada");
        }

        public static void MaestryChange()
        {
            Console.WriteLine("Maestria Alterada");
        }
    }
}