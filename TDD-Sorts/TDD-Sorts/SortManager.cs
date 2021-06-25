﻿using System;
using System.Linq;

namespace TDD_Sorts
{
    public class SortManager
    {
        public static string IntArrayToString(int[] inputArray)
        {
            if (inputArray.Length == 0)
                return "";
            
            string output = "";
            for(int i = 0; i < inputArray.Length; i++)
            {
                output += inputArray[i] + ", ";
            }
            return output.Substring(0, output.Length - 2);
        }

        public static int[] MakeIntArray(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return null;

            // remove whitespace
            inputString = inputString.Replace(" ", string.Empty);

            if (string.IsNullOrEmpty(inputString))
                return null;

            // split string
            string[] splitString = inputString.Split(',');
            int splitStringLength = splitString.Length;

            if (string.IsNullOrEmpty(splitString[splitString.Length - 1]))
                splitStringLength--;

            int[] outputArray = new int[splitStringLength];
            for(int i = 0; i < splitStringLength; i++)
            {
                outputArray[i] = int.Parse(splitString[i]);
            }

            return outputArray;
        }

        
    }
}
