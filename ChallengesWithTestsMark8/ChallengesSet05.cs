using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            {
                return startNumber + (n - (startNumber % n));
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            {
                if (numbers == null || numbers.Length == 0) return false;
                return numbers.SequenceEqual(numbers.OrderBy(n => n));
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            {
                return numbers == null
                    ? 0
                    : numbers.Skip(1)
                             .Where((n, i) => numbers[i] % 2 == 0)
                             .Sum();
            }
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            {
                if (words == null || words.Length == 0)
                    return "";

                var cleaned = words
                    .Where(w => !string.IsNullOrWhiteSpace(w))  
                    .Select(w => w.Trim());                     

                if (!cleaned.Any())
                    return "";

                return string.Join(" ", cleaned) + ".";
            }
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            {
                if (elements == null || elements.Count < 4)
                    return new double[0];

                List<double> result = new List<double>();

                for (int i = 3; i < elements.Count; i += 4) 
                {
                    result.Add(elements[i]);
                }

                return result.ToArray();
            }
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            {
                if (nums == null || nums.Length < 2)
                    return false;

                HashSet<int> seen = new HashSet<int>();

                foreach (int num in nums)
                {
                    int complement = targetNumber - num;

                    if (seen.Contains(complement))
                        return true;

                    seen.Add(num);
                }

                return false;
            }
        }
    }
}
