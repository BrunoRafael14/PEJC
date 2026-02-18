using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Games.LeagueOfLegends.LolMenu;

namespace PEJC.Core
{
    public class HomeMenu
    {
        private static readonly Dictionary<string, Action> GameOptions = new Dictionary<string, Action>
        {
            {"League of Legends", LolMenu.StartLolMenu}
        };

        public static void StartMenu()
        {
            bool loopStatusValidation = true;
            int response = 0;
            while (loopStatusValidation)
            {
                DisplayOptions();
                response = Validations.ReadIntInput();
                loopStatusValidation = Validations.MenuChoiceFilter(loopStatusValidation, response, GameOptions);
            }
            ProceedWithChoice(response);
        }

        public static void DisplayOptions()
        {
            Console.WriteLine("Escolha o jogo para estatístcas:");
            for (int counter = 0; counter < GameOptions.Count; counter++)
            {
                Console.WriteLine($"{counter + Validations.IndexCorrection}- {GameOptions.ElementAt(counter).Key}");
            }
            Console.WriteLine($"{GameOptions.Count + Validations.IndexCorrection}- Sair");
        }

        public static void ProceedWithChoice(int response)
        {
            
            if (response - Validations.IndexCorrection < GameOptions.Count){
                var gameChoice = GameOptions.ElementAt(response - Validations.IndexCorrection).Value;
                gameChoice();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}