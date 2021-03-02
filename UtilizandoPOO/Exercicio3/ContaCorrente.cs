using System;

namespace UtilizandoPOO.Exercicio3
{
    class ContaCorrente : ContaBancaria, IImprimivel
    {
        private readonly double _taxaDeOperacao;

        public ContaCorrente(int numero, double taxa)
        {
            Saldo = 0;
            NumeroDaConta = numero; 

            if (taxa < 0)
            {
                Console.WriteLine("Taxa de operação deve ser maior ou igual a zero!");
                return;
            } 

            _taxaDeOperacao = taxa;  
        }

        public override void Sacar(double valor)
        {    
            if (!ValidarValor(valor)) return;

            var valorOperacao = valor * (_taxaDeOperacao / 100.00);

            var novoSaldo = Math.Round(Saldo - valor - valorOperacao, 2); 

            if (novoSaldo < 0) 
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

            var valorOperacao = valor * (_taxaDeOperacao / 100.00);

            Saldo = Math.Round(Saldo + valor - valorOperacao, 2);

            Console.WriteLine($"Depósito de {valor} realizado!");
        }

        public void MostrarDados()
        {            
            Console.WriteLine($"Conta corrente Nº {NumeroDaConta}");
            Console.WriteLine($"Saldo atual: {Saldo}");
            Console.WriteLine($"Taxa de operação: {_taxaDeOperacao} %");
            Console.WriteLine("");
        }
    }
}