/*
Faça uma aplicação que receba N alunos com suas respectivas notas. Use foreach para a estrutura de repetição.

Crie um objeto Alunos.
Armazene os alunos em uma lista.
Imprima todos os alunos com médias superiores a 7.
*/

using System;
using System.Collections.Generic;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = LerAlunos();
            ApresentarAlunosComMediaMaiorQueSete(alunos);
        }

        static List<Aluno> LerAlunos()
        {
            List<Aluno> alunos = new List<Aluno>();

            while (true)
            {
                Console.WriteLine("Nome do aluno (vazio para sair): ");
                string nome = Console.ReadLine();

                if (nome == "") break;                          

                Aluno aluno = new Aluno();
                aluno.nome = nome;
                aluno.notas[0] = LerNumerico("Nota do 1º bimestre: ");
                aluno.notas[1] = LerNumerico("Nota do 2º bimestre: ");
                aluno.notas[2] = LerNumerico("Nota do 3º bimestre: ");
                aluno.notas[3] = LerNumerico("Nota do 4º bimestre: ");

                alunos.Add(aluno);
            }
            return alunos;                   
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

        static void ApresentarAlunosComMediaMaiorQueSete(List<Aluno> alunos)
        {
            Console.WriteLine("Alunos com média maior que 7.0:");

            foreach (Aluno aluno in alunos)
            {
                double media = (aluno.notas[0] + aluno.notas[1] + aluno.notas[2] + aluno.notas[3]) / 4;
                if (media > 7)
                {
                    Console.WriteLine($"Aluno: {aluno.nome}");                
                    Console.WriteLine($"Média: {media}");
                }
            }
        }
    }
}
