using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Sorts.Parsing
{
    public class SortManager
    {
        public static int[] MakeIntArray(string inputString)
        {
            // "1, 2, 3, 4, 5" -> "1,2,3,4,5" -> {"1","2","3","4","5"}
            // remove whitespace
            inputString = inputString.Replace(" ", string.Empty);
            
            // split string
            string[] splitString = inputString.Split(',');

            int[] outputArray = new int[splitString.Length];
            for(int i = 0; i < splitString.Length; i++)
            {
                outputArray[i] = int.Parse(splitString[i]);
            }

            return outputArray;
        }
    }
}
