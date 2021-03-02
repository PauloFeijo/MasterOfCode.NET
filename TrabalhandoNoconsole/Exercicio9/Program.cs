/*
9. Utilizando a biblioteca LINQ crie no console e execute:

Crie uma lista que receba inteiros.
Imprimir todos os números da lista.
Imprimir todos os números da lista na ordem crescente.
Imprimir todos os números da lista na ordem decrescente.
Imprima apenas o primeiro número da lista.
Imprima apenas o ultimo número da lista.
Insira um número no início da lista.
Insira um número no final da lista.
Remova o primeiro número.
Remova o último número.
Retorne apenas os números pares.
Retorne apenas o número informado.
Transforme todos os números da lista em um Array.
*/

using MDCComum;
using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsole.Exercicio9
{
    class Program
    {
        static void Main()
        {
            var tela = new Tela("Trabalhando no Console - Exercício 9");
            var entrada = new EntradaDeDados(tela);

            tela.EscreverNaCor("Apresentar números utilizando LINQ", Tela.corInformacaoDestaque);
            tela.PularLinha();

            var numeros = new List<int>();

            while (true)
            {
                var numero = entrada.LerInteiro("Informe um número (zero para sair): ");
                if (numero == 0) break;

                numeros.Add(numero);
            }
            
            if (numeros.Count == 0) return;

            tela.PularLinha();
            tela.EscreverNaMesmaLinhaENaCor("Imprimir todos os números da lista: ", Tela.corInformacaoDestaque);
            numeros.ForEach(n => tela.EscreverNaMesmaLinhaENaCor($"{n}, ", Tela.corResultado));

            tela.PularLinha();
            tela.EscreverNaMesmaLinhaENaCor("Imprimir todos os números da lista na ordem crescente: ", Tela.corInformacaoDestaque);
            numeros.OrderBy(n => n).ToList().ForEach(n => tela.EscreverNaMesmaLinhaENaCor($"{n}, ", Tela.corResultado));

            tela.PularLinha();
            tela.EscreverNaMesmaLinhaENaCor("Imprimir todos os números da lista na ordem decrescente: ", Tela.corInformacaoDestaque);
            numeros.OrderByDescending(n => n).ToList().ForEach(n => tela.EscreverNaMesmaLinhaENaCor($"{n}, ", Tela.corResultado));

            tela.PularLinha();
            tela.EscreverNaMesmaLinhaENaCor("Imprima apenas o primeiro número da lista: ", Tela.corInformacaoDestaque);
            tela.EscreverNaMesmaLinhaENaCor(numeros.First().ToString(), Tela.corResultado);

            tela.PularLinha();
            tela.EscreverNaMesmaLinhaENaCor("Imprima apenas o ultimo número da lista: ", Tela.corInformacaoDestaque);
            tela.EscreverNaMesmaLinhaENaCor(numeros.Last().ToString(), Tela.corResultado);

            tela.PularLinha();
            tela.EscreverNaMesmaLinhaENaCor("Insira um número no início da lista: ", Tela.corInformacaoDestaque);
            numeros.Insert(0, 1000);
            tela.EscreverNaMesmaLinhaENaCor(numeros.First().ToString(), Tela.corResultado);

            tela.PularLinha();
            tela.EscreverNaMesmaLinhaENaCor("Insira um número no final da lista: ", Tela.corInformacaoDestaque);
            numeros.Insert(numeros.Count, 2000);
            tela.EscreverNaMesmaLinhaENaCor(numeros.Last().ToString(), Tela.corResultado);

            tela.PularLinha();
            tela.EscreverNaMesmaLinhaENaCor("Remova o primeiro número: ", Tela.corInformacaoDestaque);
            numeros.RemoveAt(0);
            tela.EscreverNaMesmaLinhaENaCor(numeros.First().ToString(), Tela.corResultado);

            tela.PularLinha();
            tela.EscreverNaMesmaLinhaENaCor("Remova o último número: ", Tela.corInformacaoDestaque);
            numeros.RemoveAt(numeros.Count -1);
            tela.EscreverNaMesmaLinhaENaCor(numeros.Last().ToString(), Tela.corResultado);

            tela.PularLinha();
            tela.EscreverNaMesmaLinhaENaCor("Retorne apenas os números pares: ", Tela.corInformacaoDestaque);
            numeros.Where(n => (n % 2) == 0).ToList().ForEach(n => tela.EscreverNaMesmaLinhaENaCor($"{n}, ", Tela.corResultado));

            tela.PularLinha();
            tela.EscreverNaCor("Retorne apenas o número informado: ", Tela.corInformacaoDestaque);
            var num = entrada.LerInteiro("Informe um número: ");
            var numeroBusca = numeros.Where(n => (n == num)).FirstOrDefault();
            if (numeroBusca != 0) 
            {
                tela.EscreverNaCor("Número encontrado", Tela.corResultado);
            } else 
            {
                tela.EscreverNaCor("Número não encontrado", Tela.corErro);
            }

            tela.EscreverNaCor("Transforme todos os números da lista em um Array: ", Tela.corInformacaoDestaque);
            var array = numeros.ToArray();

            foreach (int n in array) 
            {
                tela.EscreverNaMesmaLinhaENaCor($"{n}, ", Tela.corResultado);
            }

            tela.PularLinha();
        }
    }
}
