using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEJC.Core
{
    public class Validations
    {
        public static bool MenuChoiceFilter(bool validationStatusLoop, int response, List<string> options)
        {
            
            //Posteriormente ver a melhor forma de tirar esse número mágico da condição
            if (response > (options.Count + 1) || response <= 0)
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