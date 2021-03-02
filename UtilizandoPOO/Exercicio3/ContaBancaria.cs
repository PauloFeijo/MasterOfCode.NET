using System;

namespace UtilizandoPOO.Exercicio3
{
    abstract class ContaBancaria
    {
        protected int NumeroDaConta { get; set; }
        protected double Saldo { get; set; }

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