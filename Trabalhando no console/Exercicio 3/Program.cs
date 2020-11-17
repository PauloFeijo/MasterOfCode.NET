/* Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição while. */

using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            while (numero <= 100)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
        }
    }
}
