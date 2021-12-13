using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase) //ignorecase means to not worry about casing (upper or lower)
        {
            bool containsWord = false;
            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase)
            {
                word = word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList(); //iterate through words and convert to lower and store in list
                containsWord = lc.Contains(word); //this will change bool to true if word exists there.
            }
            if (!ignoreCase)
            {
                containsWord = words.Contains(word); //we don't need to convert to lowercase because we are paying atttention for casing differnces
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            int a = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2) //only if nunmber is prime will a be 2 because the remainder will be zero only twice, with itself and with 1
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //int index = -1; //when there is no unique letter the test wants us to return negative 1
            //bool uniuqeIndex;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    uniuqeIndex = true;
            //    for (int j = 0; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j] && i != j) //the and is because in the begining i and j are both 0
            //        {
            //            uniuqeIndex = false; //there is nothing unique in our list.
            //        }
            //        if (uniuqeIndex == true)
            //        {
            //            index = i;
            //        }
            //    }
            //}
            //return index;
            return str.IndexOf(
                        str.Distinct()
                                .Reverse()
                                .Where(x => str.Where(y => y.Equals(x)).Count() == 1)
                                .FirstOrDefault());
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (int j = i + 1; j < numbers.Length; j++) //this way j is checking one index after i.
                {
                    if (numbers[i] != numbers[j]) //not consecutive
                    {
                        break;
                    }
                    //if they are equal
                    currentCount++;
                }
                if (currentCount > count)
                {
                    count = currentCount; //this way we will only update our count if this sequence is the biggest
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (n <= 0)
            {
                return new double[0];
            }
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            var everyNth = new List<double>();
            //int i = n - 1 because index starts from zero
            for (int i = n - 1; i < elements.Count; i += n) 
            {
                everyNth.Add(elements[i]); 
            }
            return everyNth.ToArray();
        }
    }
}
