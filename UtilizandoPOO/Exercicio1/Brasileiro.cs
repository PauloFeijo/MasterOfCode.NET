using System;
namespace UtilizandoPOO.Exercicio1 
{
    class Brasileiro : Pessoa, IExportavel 
    {
        public override string Cumprimentar () 
        {
            return "Bom dia";
        }

        public void Exportar()
        {
            Console.WriteLine("Exportando os dados do brasileiro...");
        }
    }
}