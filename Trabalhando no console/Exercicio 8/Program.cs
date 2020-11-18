/*Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente.*/

using System;
using System.Collections.Generic;

namespace Exercicio_8
{
    class Program
    {
        const float NUMERO_VAZIO = -99999;
        static void Main(string[] args)
        {
            List<float> numeros = new List<float>();

            while (true)
            {
                float numero = LerDecimal("Informe um número (vazio para sair): ");
                if (numero == NUMERO_VAZIO) break;

                numeros.Add(numero);
            }
            
            if (numeros.Count == 0) return;

            Console.WriteLine("");
            Console.Write("Numeros sem ordenação: ");
            foreach (float num in numeros)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine("");

            // Aplica a ordenação
            numeros.Sort();

            // Ordem crescente: apresenta os items
            Console.Write("Numeros em ordem crescente: ");
            foreach (float num in numeros)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine("");

            // Ordem decrescente: apresenta os items do último para o primeiro
            Console.Write("Numeros em ordem decrescente: ");
            for (int i = numeros.Count -1; i >= 0; i--)
            {
                Console.Write(numeros[i] + ", ");
            }            
        }

        static float LerDecimal(string msg) {
            Console.Write(msg);                        
            string txt = Console.ReadLine();

            if (txt == "") return NUMERO_VAZIO; 

            if (float.TryParse(txt, out float vlr))
            {
                return vlr;
            }

            Console.WriteLine("Valor inválido!");
            return LerDecimal(msg);
        }        
    }
}
