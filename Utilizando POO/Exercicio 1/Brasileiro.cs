using System;
namespace Exercicio_1 
{
    class Brasileiro : Pessoa, IExportavel 
    {
        public override void Cumprimentar () 
        {
            Console.WriteLine ("Bom dia");
        }

        public void Exportar()
        {
            Console.WriteLine("Exportando os dados do brasileiro...");
        }
    }
}