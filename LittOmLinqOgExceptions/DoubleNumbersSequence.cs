using System.Collections;

namespace LittOmLinqOgExceptions
{
    internal class DoubleNumbersSequence 
        : IEnumerable<int>, IEnumerator<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new DoubleNumbersSequence();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool MoveNext()
        {
            Current *= 2;
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
