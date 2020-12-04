/*
Crie uma classe para representar uma pessoa:

Crie os atributos privados de nome, data de nascimento e altura.
Crie os métodos públicos necessários para sets e gets e também um método para imprimir todos dados de uma pessoa.
Crie um método para calcular a idade da pessoa.
Imprima os dados via console.
*/


using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
           var pessoa = new Pessoa();

           pessoa.SetNome("Paulo Ricardo Feijó");
           pessoa.SetDataNascimento("18/11/1989");
           pessoa.SetAltura(1.70);

           Console.WriteLine(pessoa);
        }
    }
}
