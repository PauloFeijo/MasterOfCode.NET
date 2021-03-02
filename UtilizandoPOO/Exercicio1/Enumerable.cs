using System;
using System.Collections;

namespace UtilizandoPOO.Exercicio1 {

    class Enumerable {

        public string Descricao { get; set; }

        public Enumerable (string descricao) {
            Descricao = descricao;
        }
    }

    class Enumerables : IEnumerable {

        private readonly Enumerable[] _enumerables;

        public Enumerables (Enumerable[] enumerables) {
            _enumerables = new Enumerable[enumerables.Length];

            for (int i = 0; i < enumerables.Length; i++) {
                _enumerables[i] = enumerables[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public EnumerableEnum GetEnumerator () {
            return new EnumerableEnum (_enumerables);
        }
    }

    class EnumerableEnum : IEnumerator {
        public Enumerable[] Enumerables;

        private int posicao = -1;

        public EnumerableEnum (Enumerable[] enumerables) 
        {
            Enumerables = enumerables;
        }

        public bool MoveNext () 
        {
            posicao++;
            return (posicao < Enumerables.Length);
        }

        public void Reset() => posicao = -1;

        object IEnumerator.Current => Current;

        public Enumerable Current 
        {
            get
            {
                try {
                    return Enumerables[posicao];
                } catch (IndexOutOfRangeException) {
                    throw new InvalidOperationException ();
                }
            }
        }
    }
}