/*
Crie uma aplicação que calcule a fórmula de Bhaskara.

Receba os valores a, b, c.
Imprima os resultados R1 e R2.
Use a biblioteca MATH.
*/

using MDCComum;

namespace TrabalhandoNoConsole.Exercicio5
{
    class Program
    {
        static void Main()
        {
            var tela = new Tela("Trabalhando no Console - Exercício 5");
            var entrada = new EntradaDeDados(tela);

            tela.EscreverNaCor("Cálculo de Bháskara", Tela.corInformacao);
            tela.PularLinha();

            var a = entrada.LerDecimal("Informe o valor de a: ");
            var b = entrada.LerDecimal("Informe o valor de b: ");
            var c = entrada.LerDecimal("Informe o valor de c: ");

            var bhaskara = new Bhaskara(a, b, c);

            tela.PularLinha();
            tela.EscreverNaCor($"Valor de R1: {bhaskara.R1}", Tela.corResultado);
            tela.EscreverNaCor($"Valor de R2: {bhaskara.R2}", Tela.corResultado);
        }
    }
}
