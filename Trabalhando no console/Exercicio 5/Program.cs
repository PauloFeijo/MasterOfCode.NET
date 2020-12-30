/*
Crie uma aplicação que calcule a fórmula de Bhaskara.

Receba os valores a, b, c.
Imprima os resultados R1 e R2.
Use a biblioteca MATH.
*/

using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo Bhaskara");

            double a = LerNumerico("Informe o valor de a:");
            double b = LerNumerico("Informe o valor de b:");
            double c = LerNumerico("Informe o valor de c:");

            Bhaskara bhaskara = new Bhaskara(a, b, c);

            Console.WriteLine($"Valor de R1: {bhaskara.R1}");
            Console.WriteLine($"Valor de R2: {bhaskara.R2}");
        }

        static double LerNumerico(string msg) {
            Console.WriteLine(msg);                        
            string txt = Console.ReadLine(); 

            if (Double.TryParse(txt, out double vlr))
            {
                return vlr;
            }

            Console.WriteLine("Valor inválido!");
            return LerNumerico(msg);
        }
    }
}
