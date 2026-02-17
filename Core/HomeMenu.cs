using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Games.LeagueOfLegends.LolMenu;

namespace PEJC.Core
{
    public class HomeMenu
    {
        public static readonly List<string> GameOptions = new List<string>
        {
            "League of Legends"
        };

        public static void StartMenu()
        {
            bool loopStatusValidation = true;
            int response = 0;
            while (loopStatusValidation)
            {
                DisplayOptions();
                response = Convert.ToInt32(Console.ReadLine());
                loopStatusValidation = Validations.MenuChoiceFilter(loopStatusValidation, response, GameOptions);
            }
        }

        public static void DisplayOptions()
        {
            Console.WriteLine("Escolha o jogo para estatístcas:");
            for (int counter = 0; counter < GameOptions.Count; counter++)
            {
                Console.WriteLine($"{counter + 1}- {GameOptions[counter]}");
            }
            Console.WriteLine($"{GameOptions.Count + 1}- Sair");
        }
    }
}