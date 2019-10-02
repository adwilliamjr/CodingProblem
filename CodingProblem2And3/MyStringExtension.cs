using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblem2And3
{
    public static class MyStringExtension
    {
        public static string Reverse(this String s, string toReverse)
        {
            var newString = "";

            // A string is an array of characters which we can loop.
            for(int i = toReverse.Length - 1; i >= 0; i--)
            {
                newString += toReverse[i];
            }

            return newString;
        }

        public static string RemoveDuplicates(this String s, string toRemove)
        {
            var newString = "";

            for(int i = 0; i <= toRemove.Length - 1; i++)
            {
                var existing = false;

                for(int j = 0; j <= newString.Length - 1; j++)
                {
                    if(toRemove[i] == newString[j])
                    {
                        existing = true;
                    }
                }

                if(!existing)
                {
                    newString += toRemove[i];
                }
            }

            return newString;
        }
    }
}
