using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEJC.Core
{
    public class Validations
    {
        public const int IndexCorrection = 1;
        public static bool MenuChoiceFilter(bool validationStatusLoop, int response, Dictionary<string, Action> options)
        {
            
            //Posteriormente ver a melhor forma de tirar esse número mágico da condição
            if (response > (options.Count + IndexCorrection) || response < IndexCorrection)
            {
                Console.WriteLine("Opção Inválida");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}