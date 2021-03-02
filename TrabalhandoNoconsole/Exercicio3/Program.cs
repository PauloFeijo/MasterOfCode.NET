/* Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição while. */

using MDCComum;

namespace TrabalhandoNoConsole.Exercicio3
{
    class Program
    {
        static void Main()
        {
            var tela = new Tela("Trabalhando no Console - Exercício 3");

            tela.EscreverNaCor("Múltiplos de 3 de 1 a 100:", Tela.corInformacao);
            tela.PularLinha();

            var numero = 3;
            while (numero <= 100)
            {
                tela.EscreverNaMesmaLinhaENaCor($"{numero}, ", Tela.corResultado);
                numero += 3;
            }

            tela.PularLinha();
        }
    }
}
