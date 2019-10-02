using System;

namespace CodingProblem1
{
    /// <summary>
    /// Provides methods for getting highest number in an array.
    /// </summary>
    public class HighestNumber
    {
        /// <summary>
        /// Returns the nth highest number in an array.
        /// </summary>
        /// <param name="theArray"></param>
        /// <param name="nthHighest"></param>
        /// <returns></returns>
        public int Get(int[] theArray, int nthHighest)
        {
            SortDescending(theArray);

            return theArray[nthHighest - 1];
        }

        /// <summary>
        ///  Sort an array in descending order
        /// </summary>
        /// <param name="unsorted">The array with unsorted items </param>
        /// <param name="position">Parameter Used for recursion</param>
        private void SortDescending(int[] unsorted, int position = 0)
        {
            try
            {
                if (position == unsorted.Length - 1)
                {
                    return;
                }

                // Loop through the array swapping the number at position n with the number preceding it if its higher
                // thereby pushing the highest number to top of the array.
                for (int i = unsorted.Length - 1; i > position; i--)
                {
                    if (unsorted[i] > unsorted[i - 1])
                    {
                        var temp = unsorted[i - 1];
                        unsorted[i - 1] = unsorted[i];
                        unsorted[i] = temp;
                    }
                }

                SortDescending(unsorted, position + 1);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
