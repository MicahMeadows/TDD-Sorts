using System;

namespace TDD_Sorts.Sorting
{
    public class BubbleSort
    {
        public static void Sort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int t = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = t;
                    }
                }
            }
        }
    }
}
