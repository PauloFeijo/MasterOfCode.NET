/*
3) Faça uma aplicação bancária.

Crie uma classe abstrata ContaBancaria que contém como atributos, NumeroDaConta e Saldo. E como métodos abstratos Sacar e Depositar que recebem um parâmetro do tipo double.
Crie as classes ContaCorrente e ContaEspecial que herdam da ContaBancaria.
A ContaCorrente possui um atributo taxaDeOperacao que é descontado sempre que um saque e um depósito são feitos.
A ContaEspecial possui um atributo Limite que dá credito a mais para o correntista caso ele precise sacar mais que o saldo. Neste caso, o saldo pode ficar negativo desde que não ultrapasse o limite. Contudo isso não pode acontecer na classe ContaCorrente.
Crie uma interface Imprimivel que declara um método MostrarDados, implemente em ambas as contas e imprima os dados em cada uma.
Via console, abra 2 contas de cada tipo e execute todas as operações.
*/
using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaCorrente1 = new ContaCorrente(1, 0.05);
            contaCorrente1.Depositar(50.00);
            contaCorrente1.Sacar(50.00);
            contaCorrente1.MostrarDados();  

            var contaCorrente2 = new ContaCorrente(2, 0.05);
            contaCorrente2.Depositar(100.00);
            contaCorrente2.Sacar(50.00);
            contaCorrente2.MostrarDados();                       

            var contaEspecial1 = new ContaEspecial(3, 100.00);
            contaEspecial1.Depositar(100.00);
            contaEspecial1.Sacar(201.00);
            contaEspecial1.MostrarDados();   

            var contaEspecial2 = new ContaEspecial(4, 100.00);
            contaEspecial2.Depositar(100.00);
            contaEspecial2.Sacar(200.00);
            contaEspecial2.MostrarDados();                      
        }
    }
}
