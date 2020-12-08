using System;

namespace Exercicio_3
{
    class ContaCorrente : ContaBancaria, IImprimivel
    {
        private double TaxaDeOperacao;

        public ContaCorrente(int numero, double taxa)
        {
            this.Saldo = 0;
            this.NumeroDaConta = numero; 

            if (taxa < 0)
            {
                Console.WriteLine("Taxa de operação deve ser maior ou igual a zero!");
                return;
            } 

            this.TaxaDeOperacao = taxa;  
        }

        public override void Sacar(double valor)
        {    
            if (!ValidarValor(valor)) return;

            var novoSaldo = Math.Round(this.Saldo - (valor + TaxaDeOperacao), 2); 

            if (novoSaldo < 0) 
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            this.Saldo = novoSaldo;
        }

        public override void Depositar(double valor)
        {
            if (!ValidarValor(valor)) return;

            this.Saldo = Math.Round(this.Saldo + (valor - TaxaDeOperacao), 2);
        }

        public void MostrarDados()
        {            
            Console.WriteLine($"Conta corrente Nº {this.NumeroDaConta}");
            Console.WriteLine($"Saldo: {this.Saldo}");
            Console.WriteLine($"Taxa de operação: {this.TaxaDeOperacao}");
            Console.WriteLine("");
        }
    }
}