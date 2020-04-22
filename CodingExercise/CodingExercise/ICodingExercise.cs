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
        
        string RemoveDuplicateCharacterV2(string inputStr);
        
        string RemoveDuplicateCharacterV3(string inputStr);

        bool IsStringAnagram(string inputStr);

        bool IsAustralianMobileNumberValid(string mobileNumber);
    }
}
