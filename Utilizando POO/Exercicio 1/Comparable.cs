using System;
namespace Exercicio_1 
{
    class Comparable : IComparable
    {
        public int codigo { get; private set; }

        public Comparable(int codigo)
        {
            this.codigo = codigo;    
        }
        
        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;

            return this.codigo.CompareTo((obj as Comparable).codigo);          
        }
    }
}