using System;
namespace Exercicio_1 
{
    class Disposable : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("    Liberar objetos da memória da classe Disposable");   
        }
    }
}