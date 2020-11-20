/*
9. Utilizando a biblioteca LINQ crie no console e execute:

Crie uma lista que receba inteiros.
Imprimir todos os números da lista.
Imprimir todos os números da lista na ordem crescente.
Imprimir todos os números da lista na ordem decrescente.
Imprima apenas o primeiro número da lista.
Imprima apenas o ultimo número da lista.
Insira um número no início da lista.
Insira um número no final da lista.
Remova o primeiro número.
Remova o último número.
Retorne apenas os números pares.
Retorne apenas o número informado.
Transforme todos os números da lista em um Array.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio_9
{
    class Program
    {
        const int NUMERO_VAZIO = -99999;
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            while (true)
            {
                int numero = LerInteiro("Informe um número (vazio para sair): ");
                if (numero == NUMERO_VAZIO) break;

                numeros.Add(numero);
            }
            
            if (numeros.Count == 0) return;

            Console.WriteLine("");
            Console.Write("Imprimir todos os números da lista: ");
            numeros.ForEach(n => Console.Write($"{n}, "));

            Console.WriteLine("");
            Console.Write("Imprimir todos os números da lista na ordem crescente: ");
            numeros.OrderBy(n => n).ToList().ForEach(n => Console.Write($"{n}, ")); 

            Console.WriteLine("");
            Console.Write("Imprimir todos os números da lista na ordem decrescente: ");
            numeros.OrderByDescending(n => n).ToList().ForEach(n => Console.Write($"{n}, "));  

            Console.WriteLine("");
            Console.Write("Imprima apenas o primeiro número da lista: ");
            Console.Write(numeros.First());

            Console.WriteLine("");
            Console.Write("Imprima apenas o ultimo número da lista: ");
            Console.Write(numeros.Last());

            Console.WriteLine("");
            Console.Write("Insira um número no início da lista: ");
            numeros.Insert(0, 1000);
            Console.Write(numeros.First());   

            Console.WriteLine("");
            Console.Write("Insira um número no final da lista: ");
            numeros.Insert(numeros.Count, 2000);
            Console.Write(numeros.Last());  

            Console.WriteLine("");
            Console.Write("Remova o primeiro número: ");
            numeros.RemoveAt(0);
            Console.Write(numeros.First());   

            Console.WriteLine("");
            Console.Write("Remova o último número: ");
            numeros.RemoveAt(numeros.Count -1);
            Console.Write(numeros.Last());   

            Console.WriteLine("");
            Console.Write("Retorne apenas os números pares: ");
            numeros.Where(n => (n % 2) == 0).ToList().ForEach(n => Console.Write($"{n}, "));  

            Console.WriteLine("");
            Console.Write("Retorne apenas o número informado: ");
            int num = LerInteiro("Informe um número: ");
            int numFind = numeros.Where(n => (n == num)).FirstOrDefault();
            if (numFind != 0) 
            {
                Console.Write("Número encontrado");
            } else 
            {
                Console.Write("Número não encontrado");
            }

            Console.WriteLine("");
            Console.Write("Transforme todos os números da lista em um Array: ");
            int[] array = numeros.ToArray();

            foreach (int n in array) 
            {
                Console.Write($"{n}, ");
            }
        }

        static int LerInteiro(string msg) {
            Console.Write(msg);                        
            string txt = Console.ReadLine();

            if (txt == "") return NUMERO_VAZIO; 

            if (Int32.TryParse(txt, out int vlr))
            {
                return vlr;
            }

            Console.WriteLine("Número inválido!");
            return LerInteiro(msg);
        }
    }
}
