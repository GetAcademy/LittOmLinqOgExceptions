using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittOmLinqOgExceptions
{
    internal class TripleNumbersSequence : IEnumerable<int>, IEnumerator<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new TripleNumbersSequence();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            Current *= 3;
            return Current < 1000;
        }

        public void Reset()
        {
            Current = 1;
        }

        public int Current { get; set; } = 1;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
