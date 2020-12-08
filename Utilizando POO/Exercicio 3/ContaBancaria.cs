using System;

namespace Exercicio_3
{
    abstract class ContaBancaria
    {
        protected int NumeroDaConta;
        protected double Saldo;

        public abstract void Sacar(double valor);
        public abstract void Depositar(double valor);

        protected bool ValidarValor(double valor)
        {
            if (valor <= 0) 
            {
                Console.WriteLine("Valor deve ser maior que zero!");
                return false;
            }
            return true;
        }        
    }    
}