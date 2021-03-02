using System;
namespace UtilizandoPOO.Exercicio1 
{
    class Cloneable : ICloneable
    {
        public string Descricao { get; set; } 

        public object Clone()
        {
            Cloneable destino = new Cloneable
            {
                Descricao = Descricao
            };
            return destino;
        }      
    }
}