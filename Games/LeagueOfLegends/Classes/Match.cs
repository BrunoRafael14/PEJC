using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEJC.Games.LeagueOfLegends.Classes
{
    public class Match
    {
        private static int id = 0;

        int Kills {get;set;}
        int Deaths {get;set;}
        int Assists {get;set;}
        int PdlGained {get;set;}
        int MaestryGained {get;set;}
        string? LanePlayed {get;set;}
        Champion Champion {get;set;}

        public Match()
        {
            AtribuirId();
        }


            public void AtribuirId()
        {
            id++;
            Console.WriteLine($"Parabens, essa é a partida de número {id}");
        }
    }
}