using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {

        public bool ArrayContainsAFalse(bool[] vals)
        {

            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }

            }

            return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)

            {
                return false;
            }

            int sum = 0;

            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }

            }

            return sum % 2 != 0;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }

                if (hasUpper && hasLower && hasDigit)
                {
                    return true;
                }

            }

            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;


        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {

            List<int> oddNumbers = new List<int>();

            for (int odd = 0; odd <= 100; odd++)
            {
                if (odd % 2 != 0)
                {
                    oddNumbers.Add(odd);
                }
            }

            return oddNumbers.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            foreach (string word in words)
            {
                for (int i = 0; i < words.Length; i++)

                {
                    words[i] = words[i].ToUpper();
                }
            }
            return;
        }
    }
}
