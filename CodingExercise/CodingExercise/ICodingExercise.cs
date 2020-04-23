using CodingExercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise
{
    public interface ICodingExercise
    {
        MinMaxResult GetLargestAndSmallestNumber(double[] data);

        string RemoveDuplicateCharacterV1(string inputStr);
        

        bool AreStringsAnagram(string firstStr, string secondStr);

        bool IsAustralianMobileNumberValid(string mobileNumber);
    }
}
