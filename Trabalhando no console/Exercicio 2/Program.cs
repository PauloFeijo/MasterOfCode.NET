/*
Crie uma aplicação que receba nome e salário de N funcionários. Utilize a repetição for e while.

Imprima o maior salário
Imprima o menor salário.
*/

using System;
using System.Collections.Generic;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = LerFuncionarios();
            ApresentarMaiorEMenorSalario(funcionarios);
        }

        static List<Funcionario> LerFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            while (true)
            {
                Console.WriteLine("Nome do funcionário: (vazio para sair)");                        
                string nome = Console.ReadLine();

                if (nome == "") break;

                double salario = LerNumerico("Salário: ");

                funcionarios.Add(new Funcionario(nome, salario));
            }
            return funcionarios;
        }

        static double LerNumerico(string msg) {
            Console.WriteLine(msg);                        
            string txt = Console.ReadLine(); 

            if (Double.TryParse(txt, out double vlr)) return vlr;

            Console.WriteLine("Valor inválido!");
            return LerNumerico(msg);
        }

        static void ApresentarMaiorEMenorSalario(List<Funcionario> funcionarios)
        {
            double maiorSalario = 0;            
            double menorSalario = Double.MaxValue;

            if (funcionarios.Count == 0) menorSalario = 0; 

            for (int i = 0; i < funcionarios.Count; i++) 
            {
                Funcionario funcionario = funcionarios[i];

                if (funcionario.salario > maiorSalario) 
                {
                    maiorSalario = funcionario.salario;
                }

                if (funcionario.salario < menorSalario) 
                {
                    menorSalario = funcionario.salario;
                }                
            }

            Console.WriteLine($"Maior salário: {maiorSalario}.");
            Console.WriteLine($"Menor salário: {menorSalario}.");
        }
    }
}
