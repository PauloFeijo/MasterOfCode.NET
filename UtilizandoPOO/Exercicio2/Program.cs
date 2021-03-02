/*
Crie uma classe para representar uma pessoa:

Crie os atributos privados de nome, data de nascimento e altura.
Crie os métodos públicos necessários para sets e gets e também um método para imprimir todos dados de uma pessoa.
Crie um método para calcular a idade da pessoa.
Imprima os dados via console.
*/


using MDCComum;
using System;

namespace UtilizandoPOO.Exercicio2
{
    class Program
    {
        static void Main()
        {
            var tela = new Tela("Utilizando POO - Exercício 2");

            tela.EscreverNaCor("Classe Pessoa e métodos", Tela.corInformacaoDestaque);

            var pessoa = new Pessoa();

           pessoa.SetarNome("Paulo Ricardo Feijó");
           pessoa.SetarDataNascimento(DateTime.Parse("18/11/1989"));
           pessoa.SetarAltura(1.70);

           tela.EscreverNaCor(pessoa.ToString(), Tela.corResultado);
        }
    }
}
