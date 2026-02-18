using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PEJC.Games.LeagueOfLegends.LolMenu;
using System.Linq;

namespace PEJC.Core
{
    public class HomeMenu
    {
        public static Dictionary<string, Action> GameOptions = new Dictionary<string, Action>
        {
            {"League of Legends", LolMenu.StartedLolMenu}
        };
        public const int IndexCorrection = 1;

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
                Console.WriteLine($"{counter + IndexCorrection}- {GameOptions.ElementAt(counter).Key}");
            }
            Console.WriteLine($"{GameOptions.Count + IndexCorrection}- Sair");
        }

        public static void ProceedWithChoice(int response)
        {
            
            if (response - IndexCorrection < GameOptions.Count){
                var GameChoice = GameOptions.ElementAt(response - IndexCorrection).Value;
                GameChoice();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}