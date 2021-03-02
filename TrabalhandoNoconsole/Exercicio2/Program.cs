/*
Crie uma aplicação que receba nome e salário de N funcionários. Utilize a repetição for e while.

Imprima o maior salário
Imprima o menor salário.
*/

using MDCComum;
using System.Collections.Generic;

namespace TrabalhandoNoConsole.Exercicio2
{
    class Program
    {
        private static Tela tela;
        private static EntradaDeDados entrada;
        static void Main()
        {
            tela = new Tela("Trabalhando no Console - Exercício 2");
            entrada = new EntradaDeDados(tela);

            var funcionarios = LerFuncionarios();

            if (funcionarios.Count < 1)
            {
                return;
            }
            tela.PularLinha();

            ApresentarMaiorEMenorSalarioComFor(funcionarios);
            
            ApresentarMaiorEMenorSalarioComWhile(funcionarios);
        }

        static List<Funcionario> LerFuncionarios()
        {
            var funcionarios = new List<Funcionario>();

            while (true)
            {
                var nome = entrada.LerTexto("Nome do funcionário (vazio para sair): ");

                if (nome == "") break;

                var salario = entrada.LerDecimal("Salário: ");

                funcionarios.Add(new Funcionario(nome, salario));

                tela.Limpar();
            }
            return funcionarios;
        }

        static void ApresentarMaiorEMenorSalarioComFor(List<Funcionario> funcionarios)
        {
            var maiorSalario = funcionarios[0].Salario;            
            var menorSalario = maiorSalario;

            for (int i = 0; i < funcionarios.Count; i++) 
            {
                var funcionario = funcionarios[i];

                if (funcionario.Salario > maiorSalario) 
                {
                    maiorSalario = funcionario.Salario;
                }

                if (funcionario.Salario < menorSalario) 
                {
                    menorSalario = funcionario.Salario;
                }                
            }

            tela.EscreverNaCor("Usando o comando For: ", Tela.corInformacao);
            tela.EscreverNaCor($"Maior salário: {maiorSalario}.", Tela.corResultado);
            tela.EscreverNaCor($"Menor salário: {menorSalario}.", Tela.corResultado);
            tela.PularLinha();
        }

        static void ApresentarMaiorEMenorSalarioComWhile(List<Funcionario> funcionarios)
        {
            var maiorSalario = funcionarios[0].Salario;
            var menorSalario = maiorSalario;

            var i = 0;

            while (i < funcionarios.Count)
            { 
                var funcionario = funcionarios[i];

                if (funcionario.Salario > maiorSalario)
                {
                    maiorSalario = funcionario.Salario;
                }

                if (funcionario.Salario < menorSalario)
                {
                    menorSalario = funcionario.Salario;
                }

                i++;
            }

            tela.EscreverNaCor("Usando o comando While: ", Tela.corInformacao);
            tela.EscreverNaCor($"Maior salário: {maiorSalario}.", Tela.corResultado);
            tela.EscreverNaCor($"Menor salário: {menorSalario}.", Tela.corResultado);
            tela.PularLinha();
        }
    }
}
