using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            {
                if (words == null || word == null)
                    return false;

                StringComparison comparison = ignoreCase
                    ? StringComparison.OrdinalIgnoreCase
                    : StringComparison.Ordinal;

                foreach (var w in words)
                {
                    if (w != null && string.Equals(w, word, comparison))
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public bool IsPrimeNumber(int num)
        {
            {
                if (num <= 1)
                    return false;

                if (num == 2)
                    return true;

                if (num % 2 == 0)
                    return false;

                int boundary = (int)Math.Sqrt(num);

                for (int i = 3; i <= boundary; i += 2)
                {
                    if (num % i == 0)
                        return false;
                }

                return true;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            {
                if (string.IsNullOrEmpty(str)) return -1;

                return str
                    .Select((c, i) => new { Char = c, Index = i })          
                    .Where(x => str.Count(c => c == x.Char) == 1)          
                    .Select(x => x.Index)                                  
                    .DefaultIfEmpty(-1)                                    
                    .Max();                                                
            }
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            {
                if (numbers == null || numbers.Length == 0)
                    return 0;

                int maxCount = 1;
                int currentCount = 1;

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] == numbers[i - 1])
                        currentCount++;
                    else
                        currentCount = 1;

                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }

                return maxCount;
            }

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            {
                if (elements == null || n <= 0)
                    return new double[0];

                List<double> result = new List<double>();

                for (int i = n - 1; i < elements.Count; i += n)
                {
                    result.Add(elements[i]);
                }

                return result.ToArray();
            }
        }
    }
}
