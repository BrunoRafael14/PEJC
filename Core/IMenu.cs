using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEJC.Core
{
    public class IMenu
    {
        public static void StartMenu(Dictionary<string, Action> Options)
        {
            bool loopStatusValidation = true;
            int response = 0;
            while (loopStatusValidation)
            {
                DisplayOptions(Options);
                response = Validations.ReadIntInput();
                loopStatusValidation = Validations.MenuChoiceFilter(loopStatusValidation, response, Options);
            }
            ProceedWithChoice(response, Options);
        }

        public static void DisplayOptions(Dictionary<string, Action> Options)
        {
            Console.WriteLine("Escolha a opção para Prosseguir:");
            for (int counter = 0; counter < Options.Count; counter++)
            {
                Console.WriteLine($"{counter + Validations.IndexCorrection}- {Options.ElementAt(counter).Key}");
            }
            Console.WriteLine($"{Options.Count + Validations.IndexCorrection}- Sair");
        }

        public static void ProceedWithChoice(int response, Dictionary<string, Action> Options)
        {
            
            if (response - Validations.IndexCorrection < Options.Count){
                var gameChoice = Options.ElementAt(response - Validations.IndexCorrection).Value;
                gameChoice();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}