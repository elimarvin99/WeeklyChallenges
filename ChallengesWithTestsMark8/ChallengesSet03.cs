using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var place = new List<int>();
            if (numbers == null)
            {
                return false;
            }
            else
            {
                foreach (var item in numbers)
                {
                    if (item % 2 != 0)
                    {
                        place.Add(item);
                    }
                }
                if (place.Sum() % 2 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            var truthlist = new bool[] { false, false, false };
            if (password.Any(char.IsUpper))
            {
                truthlist[0] = true;
            }
            if (password.Any(char.IsLower))
            {
                truthlist[1] = true;
            }
            if (password.Any(char.IsNumber))
            {
                truthlist[2] = true;
            }
            if (truthlist.Contains(false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var odds = new int[] {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99
            };

            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
