using System;
namespace Exercicio_1 
{
    class Cloneable : ICloneable
    {
        public string descricao { get; set; } 

        public Object Clone()
        {
            Cloneable destino = new Cloneable();
            destino.descricao = this.descricao;
            return destino;
        }      
    }
}