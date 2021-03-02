/*Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente.*/

using MDCComum;
using System.Collections.Generic;

namespace TrabalhandoNoConsole.Exercicio8
{
    class Program
    {
        static void Main()
        {
            var tela = new Tela("Trabalhando no Console - Exercício 8");
            var entrada = new EntradaDeDados(tela);

            tela.EscreverNaCor("Imprimir números em ordem crescente e decrescente", Tela.corInformacaoDestaque);
            tela.PularLinha();

            var numeros = new List<double>();

            while (true)
            {
                var numero = 0.0;
                if (!entrada.LerDecimal("Informe um número (vazio para sair): ", ref numero))
                {
                    break;
                }

                numeros.Add(numero);
            }
            
            if (numeros.Count == 0)
            {
                return;
            }

            tela.PularLinha();

            tela.EscreverNaCor("Números sem ordenação: ", Tela.corInformacaoDestaque);

            foreach (double num in numeros)
            {
                tela.EscreverNaMesmaLinhaENaCor(num + ", ", Tela.corResultado);
            }
            tela.PularLinha(2);

            // Aplica a ordenação
            numeros.Sort();

            // Ordem crescente: apresenta os items
            tela.EscreverNaCor("Números em ordem crescente: ", Tela.corInformacaoDestaque);

            foreach (double num in numeros)
            {
                tela.EscreverNaMesmaLinhaENaCor(num + ", ", Tela.corResultado);
            }
            tela.PularLinha(2);

            // Ordem decrescente: apresenta os items do último para o primeiro
            tela.EscreverNaCor("Números em ordem decrescente: ", Tela.corInformacaoDestaque);

            for (int i = numeros.Count -1; i >= 0; i--)
            {
                tela.EscreverNaMesmaLinhaENaCor(numeros[i] + ", ", Tela.corResultado);
            }
            tela.PularLinha(2);
        }        
    }
}
