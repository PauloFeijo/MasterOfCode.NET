using System;
namespace UtilizandoPOO.Exercicio1 
{
    class Conta : IExportavel
    {
        public double Saldo {get; private set;}

        public void Depositar(double vlr) => Saldo += vlr;

        public void Sacar(double vlr) => Saldo -= vlr;

        public void Exportar()
        {
            Console.WriteLine("Exportando os dados da conta...");
        }
    }
}