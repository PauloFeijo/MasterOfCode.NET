/*
Responda e demonstre no código os itens abaixo:

O que é POO?
O que é polimorfismo?
O que é abstração?
O que é encapsulamento?
Quando usar uma classe abstrata e quando devo usar uma interface?
O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
Existe herança múltipla (de classes) em C#?
*/
using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarOqueEhPOO();
            MostrarOQueEhPolimorfismo();
        }

        static void MostrarOqueEhPOO()
        {
            Console.WriteLine("O que é POO?");
            Console.WriteLine("Programação orientada a objetos (POO, ou OOP segundo as suas siglas em inglês) é um paradigma "+
              "de programação baseado no conceito de \"objetos\", que podem conter dados na forma de campos, também conhecidos "+
              "como atributos, e códigos, na forma de procedimentos, também conhecidos como métodos. Uma característica de objetos "+
              "é que um procedimento de objeto pode acessar, e geralmente modificar, os campos de dados do objeto com o qual eles "+
              "estão associados (objetos possuem uma noção de \"this\" (este) ou \"self\" (próprio)).");
            // fonte: https://pt.wikipedia.org/wiki/Programa%C3%A7%C3%A3o_orientada_a_objetos
            Console.WriteLine("");
        }

        static void MostrarOQueEhPolimorfismo()
        {
            Console.WriteLine("O que é Polimorfismo?");
            Console.WriteLine("Polimorfismo é o princípio pelo qual duas ou mais classes derivadas de uma mesma superclasse podem invocar "+
              "métodos que têm a mesma identificação (assinatura) mas comportamentos distintos, especializados para cada classe derivada, "+
              "usando para tanto uma referência a um objeto do tipo da superclasse. A decisão sobre qual o método que deve ser selecionado, "+
              "de acordo com o tipo da classe derivada, é tomada em tempo de execução, através do mecanismo de ligação tardia.");
            Console.WriteLine("");

            Console.WriteLine("No exemplo abaixo, temos a classe \"Pessoa\" que contêm o método \"Cumprimentar\". As classes filhas \"Ingles\", "+
              "\"Brasileiro\" e \"Paranaense\" sobrescrevem este método de acordo com sua particularidade: ");
            Console.WriteLine("");

            Pessoa brasileiro = new Brasileiro();
            Pessoa ingles = new Ingles();
            Pessoa paranaense = new Paranaense();

            Console.WriteLine("Cumprimentar o Brasileiro:");
            Cumprimentar(brasileiro);
            Console.WriteLine("");

            Console.WriteLine("Cumprimentar o Inglês:");
            Cumprimentar(ingles);
            Console.WriteLine("");

            Console.WriteLine("Cumprimentar o Paranaense:");
            Cumprimentar(paranaense);
            Console.WriteLine("");
        }

        static void Cumprimentar(Pessoa pessoa)
        {
            pessoa.Cumprimentar();
        }
    }
}
