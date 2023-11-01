using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Sam.Coach.Tests")]

namespace Sam.Coach
{
    internal class LongestRisingSequenceFinder : ILongestRisingSequenceFinder
    {
        public Task<IEnumerable<int>> Find(IEnumerable<int> numbers) => Task.Run(() =>
        {
            IEnumerable<int> result = null;

            
            // TODO: return the longest raising sequence in the collection provided, i.e.
            // when numbers = [4, 6, -3, 3, 7, 9] then expected result is [-3, 3, 7, 9]
            // when numbers = [9, 6, 4, 5, 2, 0] then expected result is [4, 5]

            var numList = numbers.ToList();

            // Variables to track the start and end of the current sequence
            int currentStart = 0;
            int currentEnd = 0;
            
            // Variables to track the start and end of the longest sequence
            int longestStart = 0;
            int longestEnd = 0;

            for (int i = 1; i < numList.Count; i++)
            {
                if (numList[i] > numList[i - 1])
                {
                    currentEnd = i;
                    if (currentEnd - currentStart > longestEnd - longestStart)
                    {
                        longestStart = currentStart;
                        longestEnd = currentEnd;
                    }
                }
                else
                {
                    currentStart = i;
                    currentEnd = i;
                }
            }

            // Extract the longest sequence from the original list and assign to result
            result = numList.Skip(longestStart).Take(longestEnd - longestStart + 1);

            return result;
        });
    }
}
