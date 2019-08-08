using System.Collections;
using System.Collections.Generic;

namespace Features_Iterators
{
    public class MyEnumerator : IEnumerator<int>
    {
        private int _currentIndex = -1;
        private int[] _list;

        public int Current { get { return _list[_currentIndex]; } }

        object IEnumerator.Current { get { return Current; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyEnumerator"/> class.
        /// </summary>
        /// <param name="list">The list.</param>
        public MyEnumerator(int[] list)
        {
            _list = list;
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // ...
        }

        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns>
        /// true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.
        /// </returns>
        public bool MoveNext()
        {
            _currentIndex++;

            return (_currentIndex < _list.Length);
        }

        /// <summary>
        /// Sets the enumerator to its initial position, which is before the first element in the collection.
        /// </summary>
        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
