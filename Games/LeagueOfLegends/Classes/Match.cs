using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEJC.Games.LeagueOfLegends.Classes
{
    public class Match
    {
        int Kills {get;set;}
        int Deaths {get;set;}
        int Assists {get;set;}
        int PdlGained {get;set;}
        int MaestryGained {get;set;}
        string? LanePlayed {get;set;}
    }
}