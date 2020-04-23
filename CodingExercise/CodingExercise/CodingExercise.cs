using CodingExercise.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.RegularExpressions;

namespace CodingExercise
{
    public class CodingExercise : ICodingExercise
    {
        public MinMaxResult GetLargestAndSmallestNumber(double[] data)
        {
            MinMaxResult result = new MinMaxResult();
            if (data == null || data.Length == 0)
            {
                //TODO: Log it
                return result;
            }
            for(int i=0; i<data.Length; i++)
            {
                if (!result.LargestNumber.HasValue || data[i] > result.LargestNumber)
                    result.LargestNumber = data[i];

                if (!result.SmallestNumber.HasValue || data[i] < result.SmallestNumber)
                    result.SmallestNumber = data[i];
            }
            return result;
        }

        public bool IsAustralianMobileNumberValid(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, @"^(?:\+?61|0)4 ?(?:[ -]?[0-9]){7}[0-9]$");
        }

        public bool AreStringsAnagram(string firstStr, string secondStr)
        {
            if(firstStr == null || secondStr==null || (firstStr.Length == 0 && secondStr.Length == 0))
            {
                throw new ArgumentNullException("firstStr or secondStr are not populated.");
            }

            if (firstStr.Length != secondStr.Length)
                return false;

            //Dictionaries to manage char count of both first and second string.
            var dic = new Dictionary<char, int>();

            var firstStrArray = firstStr.ToLower().ToCharArray();
            var secondStrArray = secondStr.ToLower().ToCharArray();

            for(int i=0; i<firstStrArray.Length; i++)
            {
                //characters of first string increment the count  for each character
                if (dic.ContainsKey(firstStrArray[i]))
                {
                    dic[firstStrArray[i]]++;
                    if (dic[firstStrArray[i]] == 0)
                        dic.Remove(firstStrArray[i]);
                }
                else
                {
                    dic.Add(firstStrArray[i], 1);
                }

                //characters of second string decrement the count  for each character
                if (dic.ContainsKey(secondStrArray[i]))
                {
                    dic[secondStrArray[i]]--;
                    if (dic[secondStrArray[i]] == 0) 
                        dic.Remove(secondStrArray[i]);
                }
                else
                {
                    dic.Add(secondStrArray[i], -1);
                }
            }
            return dic.Count == 0 ;
        }



        public string RemoveDuplicateCharacterV1(string inputStr)
        {
            if(inputStr==null)
            {
                throw new ArgumentNullException("inputStr");
            }
            var chars = inputStr.ToCharArray();
            var hashCheck = new HashSet<char>();
            string retString = "";
            for(int i=0; i<chars.Length; i++)
            {
                if (!hashCheck.Contains(char.ToLowerInvariant(chars[i])))
                {
                    retString += chars[i].ToString();
                    hashCheck.Add(char.ToLowerInvariant(chars[i]));
                }
            }
            return retString;
        }
    }
}
