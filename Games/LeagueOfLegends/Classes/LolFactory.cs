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
            Console.WriteLine("Digite a quantidade Total de Maestria com o Campeoão: ");
            double championMaestry = Convert.ToDouble(Console.ReadLine());

            Champion champion = new Champion();
            champion.Name = championName;
            champion.Maestry = championMaestry;


            return champion;
        }
    }
}