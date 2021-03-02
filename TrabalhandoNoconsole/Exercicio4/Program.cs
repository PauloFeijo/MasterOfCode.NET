/*
Faça uma aplicação que receba N alunos com suas respectivas notas. Use foreach para a estrutura de repetição.

Crie um objeto Alunos.
Armazene os alunos em uma lista.
Imprima todos os alunos com médias superiores a 7.
*/

using MDCComum;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsole.Exercicio4
{
    class Program
    {
        private static Tela tela;
        private static EntradaDeDados entrada;
        static void Main()
        {
            tela = new Tela("Trabalhando no Console - Exercício 4");
            entrada = new EntradaDeDados(tela);

            var alunos = LerAlunos();
            ApresentarAlunosComMediaMaiorQueSete(alunos);
        }

        static List<Aluno> LerAlunos()
        {
            var alunos = new List<Aluno>();

            while (true)
            {
                tela.Limpar();

                var nome = entrada.LerTexto("Nome do aluno (vazio para sair): ");

                if (nome == "") break;

                var aluno = new Aluno
                {
                    Nome = nome
                };

                for (int i = 0; i < aluno.Notas.Length; i++)
                {
                    aluno.Notas[i] = entrada.LerDecimal($"Nota do {i + 1}º bimestre: ");
                }

                alunos.Add(aluno);
            }
            return alunos;                   
        }

        static void ApresentarAlunosComMediaMaiorQueSete(List<Aluno> alunos)
        {
            tela.Limpar();

            tela.EscreverNaCor("Alunos com média maior que 7.0:", Tela.corInformacao);

            var alunosComMediaMaiorQueSete = alunos.Where(a => a.Notas.Average() > 7);

            tela.PularLinha();
            foreach (Aluno aluno in alunosComMediaMaiorQueSete)
            {
                tela.EscreverNaCor($"{aluno.Nome} - Média: {aluno.Notas.Average()}", Tela.corResultado);
            }
        }
    }
}
