using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Sorts.Sorting
{
    public class InsertionSort
    {
        public static void Sort(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                int key = numbers[i];

                int j = i - 1;
                while(j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[++j] = key;
            }
        }
    }
}
