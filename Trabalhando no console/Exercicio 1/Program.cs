/*
Crie uma aplicação, que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados.

Some esses 2 valores;
Faça uma subtração do valor A - B;
Divida o valor B por A;
Multiplique o valor A por B;
Imprima os valores de entrada, informado se o número é par ou ímpar;
Imprima todos os resultados no console, de forma que o usuário escolha a ação desejada.
*/

using System;
using Exercicio_1;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {        
            Calculadora calc = new Calculadora();
            LerValores(ref calc.valorA, ref calc.valorB);

            int op = -1;
            while (op != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------");
                //Console.WriteLine("Selecione uma opção informando o código:");
                Console.WriteLine("1 - Informar valores de entrada");
                Console.WriteLine("2 - Exibir valores de entrada");
                Console.WriteLine("3 - Somar");
                Console.WriteLine("4 - Subtrair");
                Console.WriteLine("5 - Dividir");
                Console.WriteLine("6 - Multiplicar");
                Console.WriteLine("0 - Sair");

                op = LerValor("Informe o número da opção desejada:");

                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------");

                switch (op)
                {
                    case 0:
                        break;
                    case 1: 
                        LerValores(ref calc.valorA, ref calc.valorB);
                        break;
                    case 2: 
                        Console.WriteLine($"O valor de A é: {calc.valorA} e ele é {ParOuImpar(calc.valorA)}");
                        Console.WriteLine($"O valor de B é: {calc.valorB} e ele é {ParOuImpar(calc.valorB)}"); 
                        break;                     
                    case 3: 
                        Console.WriteLine($"Soma: {calc.Somar()}");
                        break;
                    case 4: 
                        Console.WriteLine($"Subtração: {calc.Subtrair()}");
                        break;  
                    case 5: 
                        Console.WriteLine($"Divisão: {calc.Dividir()}");
                        break;
                    case 6: 
                        Console.WriteLine($"Multiplicação: {calc.Multiplicar()}");
                        break;                                         
                    default: 
                        Console.WriteLine("Opção inválida!");
                        break;
                }                
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("");
            }
        }

        static void LerValores(ref int valorA, ref int valorB)
        {
            valorA = LerValor("Informe o valor de A:");
            valorB = LerValor("Informe o valor de B:");
        }

        static string ParOuImpar(int valor) 
        {
            if (valor % 2 == 0) 
            {
                return "par";
            }
            return "impar";
        }

        static int LerValor(string msg) {
            Console.WriteLine(msg);                        
            string txt = Console.ReadLine(); 

            if (Int32.TryParse(txt, out int vlr))
            {
                return vlr;
            }

            Console.WriteLine("Valor inválido!");
            return LerValor(msg);
        }
    }
}
