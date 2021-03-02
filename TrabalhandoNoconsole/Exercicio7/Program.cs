/*7. Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares.*/

using MDCComum;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsole.Exercicio7
{
    class Program
    {
        private const int _qtdNumeros = 4;
               
        static void Main()
        {
            var tela = new Tela("Trabalhando no Console - Exercício 7");
            var entrada = new EntradaDeDados(tela);

            tela.EscreverNaCor("Soma dos números pares", Tela.corInformacaoDestaque);
            tela.PularLinha();

            var numeros = new List<int>(); 

            for (int i = 0; i < _qtdNumeros; i++)
            {
                numeros.Add(entrada.LerInteiro($"{i + 1}º número: "));
            }

            var somaPar = numeros.Where(n => n % 2 == 0).Sum();

            tela.PularLinha();
            tela.EscreverNaCor($"A soma dos números pares é: {somaPar}", Tela.corResultado);
        }       
    }
}
