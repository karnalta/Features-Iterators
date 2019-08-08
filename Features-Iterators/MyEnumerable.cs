using System.Collections;
using System.Collections.Generic;

namespace Features_Iterators
{
    public class MyEnumerable : IEnumerable<int>
    {
        public int[] Values { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyEnumerable"/> class.
        /// </summary>
        /// <param name="values">The values.</param>
        public MyEnumerable(int[] values)
        {
            Values = values;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// 
        /// Default enumerator implemented by MyEnumerator class.
        /// 
        /// </summary>
        /// <returns>
        /// An enumerator that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<int> GetEnumerator()
        {
            return new MyEnumerator(Values);
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Gets the multiplied enumerator.
        /// 
        /// Custom enumerator directly implemented by yield return / yield break.
        /// 
        /// </summary>
        /// <param name="multiplier">The multiplier.</param>
        /// <returns></returns>
        public IEnumerable<int> GetMultipliedEnumerator(int multiplier)
        {
            for (int i = 0; i < Values.Length; i++)
            {
                yield return Values[i] * multiplier;
            }
        }

        /// <summary>
        /// Gets the infinite enumerator.
        /// 
        /// Custom enumerator directly implemented by yield return / yield break.
        /// 
        /// </summary>
        /// <param name="maxCount">The maximum count.</param>
        /// <returns></returns>
        public IEnumerable<int> GetInfiniteEnumerator(int maxCount)
        {
            for (int i = 0; i < maxCount; i++)
            {
                int realIndex = i;
                if (i >= Values.Length)
                    realIndex = i % Values.Length;

                yield return Values[realIndex];
            }
        }
    }
}
