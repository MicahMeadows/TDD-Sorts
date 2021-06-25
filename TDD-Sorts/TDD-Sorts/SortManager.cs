using System.Linq;

namespace TDD_Sorts
{
    public class SortManager
    {
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
