using System;
using System.Collections;

namespace Exercicio_1 {

    public class Enumerable {

        public string descricao { get; set; }

        public Enumerable (string descricao) {
            this.descricao = descricao;
        }
    }

    public class Enumerables : IEnumerable {

        private Enumerable[] enumerables;

        public Enumerables (Enumerable[] enumerables) {
            this.enumerables = new Enumerable[enumerables.Length];

            for (int i = 0; i < enumerables.Length; i++) {
                this.enumerables[i] = enumerables[i];
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator () {
            return (IEnumerator) GetEnumerator ();
        }

        public EnumerableEnum GetEnumerator () {
            return new EnumerableEnum (enumerables);
        }
    }

    public class EnumerableEnum : IEnumerator {
        public Enumerable[] enumerables;

        int pos = -1;

        public EnumerableEnum (Enumerable[] enumerables) {
            this.enumerables = enumerables;
        }

        public bool MoveNext () {
            pos++;
            return (pos < enumerables.Length);
        }

        public void Reset () {
            pos = -1;
        }

        object IEnumerator.Current {
            get {
                return Current;
            }
        }

        public Enumerable Current {
            get {
                try {
                    return enumerables[pos];
                } catch (IndexOutOfRangeException) {
                    throw new InvalidOperationException ();
                }
            }
        }
    }
}