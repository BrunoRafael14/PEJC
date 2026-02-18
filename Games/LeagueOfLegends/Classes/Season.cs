using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEJC.Games.LeagueOfLegends.Classes
{
    public class Season
    {
        public string? SeasonReference {get;set;}
        public bool Situation {get;set;}
        public List<Match>? Match {get;set;}
    }
}