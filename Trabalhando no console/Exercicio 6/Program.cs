/*6. Crie uma aplicação, que demonstre a diferença entre REF e OUT.*/

using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diferença entre REF e OUT:");
            Console.WriteLine("");

            string texto = "Valor original";
            Console.WriteLine($"Valor inicial: [{texto}]");
            Console.WriteLine("");

            PassarParametroComum(texto);
            Console.WriteLine($"O Valor não é modificado: [{texto}]");
            Console.WriteLine("");

            PassarParametroREF(ref texto);
            Console.WriteLine($"O Valor é modificado: [{texto}]");
            Console.WriteLine("");

            texto = "Valor original";
            PassarParametroOUT(out texto);
            Console.WriteLine($"O valor é modificado: [{texto}]");                                 
        }

        static void PassarParametroComum(string txt)
        {
            Console.WriteLine($"Passagem de parâmetro comum: O valor chega no método: [{txt}]");
            txt = "Modificado comum";
        }

        static void PassarParametroREF(ref string txt)
        {
            Console.WriteLine($"Passagem de parâmetro REF: O valor original chega no método: [{txt}]");
            txt = "Modificado REF";
        }

        static void PassarParametroOUT(out string txt)
        {
            Console.WriteLine("Passagem de parâmetro OUT: O valor original NÃO chega no método: [o compilador não deixa utilizar uma variavel out não inicializada]");
            txt = "Modificado OUT";
        }               
    }
}
