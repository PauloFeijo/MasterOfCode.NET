/*
Crie uma aplicação, que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados.

Some esses 2 valores;
Faça uma subtração do valor A - B;
Divida o valor B por A;
Multiplique o valor A por B;
Imprima os valores de entrada, informado se o número é par ou ímpar;
Imprima todos os resultados no console, de forma que o usuário escolha a ação desejada.
*/

using MDCComum;

namespace TrabalhandoNoConsole.Exercicio1
{
    class Program
    {
        static void Main()
        {
            var tela = new Tela("Trabalhando no Console - Exercício 1");
            var entrada = new EntradaDeDados(tela);

            var calc = new Calculadora
            {
                ValorA = entrada.LerDecimal("Informe o valor de A: "),
                ValorB = entrada.LerDecimal("Informe o valor de B: ")
            };

            tela.Limpar();

            var op = -1;
            while (op != 0)
            {
                string[] opcoes = 
                {
                    "1 - Informar valores de entrada",
                    "2 - Exibir valores de entrada",
                    "3 - Somar",
                    "4 - Subtrair",
                    "5 - Dividir",
                    "6 - Multiplicar",
                    "0 - Sair"
                 };
                op = entrada.SelecionarItemMenuOpcoes("Informe o número da opção desejada: ", opcoes);

                tela.Limpar();

                switch (op)
                {
                    case 0:
                        tela.Finalizar();
                        break;
                    case 1:
                        calc.ValorA = entrada.LerDecimal("Informe o valor de A: ");
                        calc.ValorB = entrada.LerDecimal("Informe o valor de B: ");
                        break;
                    case 2:
                        tela.EscreverNaCor($"O valor de A é: {calc.ValorA} e ele é {ParOuImpar(calc.ValorA)}", Tela.corResultado);
                        tela.EscreverNaCor($"O valor de B é: {calc.ValorB} e ele é {ParOuImpar(calc.ValorB)}", Tela.corResultado); 
                        break;                     
                    case 3:
                        tela.EscreverNaCor($"Resultado da soma: {calc.Somar()}", Tela.corResultado);
                        break;
                    case 4:
                        tela.EscreverNaCor($"Resultado da subtração: {calc.Subtrair()}", Tela.corResultado);
                        break;  
                    case 5:
                        tela.EscreverNaCor($"Resultado da divisão: {calc.Dividir()}", Tela.corResultado);
                        break;
                    case 6:
                        tela.EscreverNaCor($"Resultado da multiplicação: {calc.Multiplicar()}", Tela.corResultado);
                        break;                                         
                    default:
                        tela.EscreverNaCor("Opção inválida!", Tela.corResultado);
                        break;
                }
                tela.PularLinha();
            }
        }

        static string ParOuImpar(double valor) 
        {
            if (valor % 2 == 0) 
            {
                return "par";
            }
            return "impar";
        }       
    }
}
