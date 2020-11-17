/*7. Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares.*/

using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = LerInteiro("Primeiro número:");
            int n2 = LerInteiro("Segundo número:");
            int n3 = LerInteiro("Terceiro número:");
            int n4 = LerInteiro("Quarto número:");

            int somaPar = 0;

            if (n1 % 2 == 0) somaPar += n1;
            if (n2 % 2 == 0) somaPar += n2;
            if (n3 % 2 == 0) somaPar += n3;
            if (n4 % 2 == 0) somaPar += n4;

            Console.WriteLine($"A soma dos números pares é: {somaPar}");
        }

        static int LerInteiro(string msg) {
            Console.WriteLine(msg);                        
            string txt = Console.ReadLine(); 

            if (Int32.TryParse(txt, out int vlr))
            {
                return vlr;
            }

            Console.WriteLine("Valor inválido!");
            return LerInteiro(msg);
        }        
    }
}
