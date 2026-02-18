using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEJC.Games.LeagueOfLegends.Classes
{
    public class Match
    {
        public int Kills {get;set;}
        public int Deaths {get;set;}
        public int Assists {get;set;}
        public int PdlGained {get;set;}
        public int MaestryGained {get;set;}
        public string? LanePlayed {get;set;}
        public Champion? Champion {get;set;}
    }
}