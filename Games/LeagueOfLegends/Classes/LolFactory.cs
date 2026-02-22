using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEJC.Games.LeagueOfLegends.Classes
{
    public class LolFactory
    {
        // Classe para instanciar as classes
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
            Console.WriteLine("Informe quantidade de Kills: ");
            int killsMatch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe quantidade de Mortes: ");
            int deathsMatch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe quantidade de Assistências: ");
            int assistsMatch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe quantidade de PDL Ganho: ");
            int pdlGainedMatch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe quantidade de Maestria Ganha: ");
            int maestryGainedMatch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a Lane Jogada (Toplane, Midlane, Jungle, Atirador, Suporte): ");
            string? LanePlayedMath = Console.ReadLine();
            Console.WriteLine("Informe Nome do Campeão utilizado: ");
            string? ChampionMath = Console.ReadLine();

            Match match = new Match();
            match.Kills = killsMatch;
            match.Deaths = deathsMatch;
            match.Assists = assistsMatch;
            match.PdlGained = pdlGainedMatch;
            match.MaestryGained = maestryGainedMatch;
            match.LanePlayed = LanePlayedMath;
            // Falta colocar o champion, ainda vou ver como consigo adicionar adicionar o campeão sem instanciar a outra classe Champion

            return match;
        }
    }
}