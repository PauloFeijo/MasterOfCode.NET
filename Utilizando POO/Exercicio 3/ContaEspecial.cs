using System;

namespace Exercicio_3
{
    class ContaEspecial : ContaBancaria, IImprimivel
    {
        private double Limite;

        public ContaEspecial(int numero, double limite)
        {
            this.Saldo = 0;
            this.NumeroDaConta = numero;

            if (limite < 0)
            {
                Console.WriteLine("Valor limite deve ser maior ou igual a zero!");
                return;
            }             
            this.Limite = limite;
        }

        public override void Sacar(double valor)
        {
            if (!ValidarValor(valor)) return;

            var novoSaldo = this.Saldo - valor;

            if (novoSaldo < Limite * -1) 
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            this.Saldo = novoSaldo;
        }

        public override void Depositar(double valor)
        {
            if (!ValidarValor(valor)) return;

            this.Saldo += valor;
        } 

        public void MostrarDados()
        {            
            Console.WriteLine($"Conta especial Nº {this.NumeroDaConta}");
            Console.WriteLine($"Saldo: {this.Saldo}");
            Console.WriteLine($"Saldo + limite: {this.Saldo + this.Limite}");
            Console.WriteLine("");
        }  
    }
}