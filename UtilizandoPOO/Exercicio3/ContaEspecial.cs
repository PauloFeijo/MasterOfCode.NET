using System;

namespace UtilizandoPOO.Exercicio3
{
    class ContaEspecial : ContaBancaria, IImprimivel
    {
        private readonly double _limite;

        public ContaEspecial(int numero, double limite)
        {
            Saldo = 0;
            NumeroDaConta = numero;

            if (limite < 0)
            {
                Console.WriteLine("Valor limite deve ser maior ou igual a zero!");
                return;
            }             
            _limite = limite;
        }

        public override void Sacar(double valor)
        {
            if (!ValidarValor(valor)) return;

            var novoSaldo = Saldo - valor;

            if (novoSaldo < _limite * -1) 
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            Saldo = novoSaldo;
            Console.WriteLine($"Saque de {valor} realizado!");
        }

        public override void Depositar(double valor)
        {
            if (!ValidarValor(valor)) return;

            Saldo += valor;

            Console.WriteLine($"Depósito de {valor} realizado!");
        } 

        public void MostrarDados()
        {            
            Console.WriteLine($"Conta especial Nº {NumeroDaConta}");
            Console.WriteLine($"Saldo atual: {Saldo}");
            Console.WriteLine($"Saldo atual + limite: {Saldo + _limite}");
            Console.WriteLine("");
        }  
    }
}