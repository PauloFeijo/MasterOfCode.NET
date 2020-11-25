using System;
namespace Exercicio_1 
{
    class Conta : IExportavel
    {
        public double saldo {get; private set;}

        public void Depositar(double vlr)
        {
            this.saldo += vlr;
        }

        public void Sacar(double vlr)
        {
            this.saldo -= vlr;
        }

        public void Exportar()
        {
            Console.WriteLine("Exportando os dados da conta...");
        }
    }
}