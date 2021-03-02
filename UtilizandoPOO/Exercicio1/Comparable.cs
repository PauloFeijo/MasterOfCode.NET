using System;
namespace UtilizandoPOO.Exercicio1 
{
    class Comparable : IComparable
    {
        public int Codigo { get; private set; }

        public Comparable(int codigo)
        {
            Codigo = codigo;    
        }
        
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            return Codigo.CompareTo((obj as Comparable).Codigo);          
        }
    }
}