using System;

namespace TDD_Sorts.Sorting
{
    // Bubble sort is a very simple sorting algorithm
    // that works by iterating through array and swapping
    // adjacent elements when they are in the wrong order

    // Bubble sort is not very efficient especially when
    // dealing with larger arrays
    // Time Complexity:
    // Best Case: O(n) * only when modified to check if made no swaps on first pass
    // Worst Case: O(n^2)
    // Average Case: O(n^2)

    public class BubbleSort
    {
        public static void Sort(int[] input)
        {
            if (input.Length <= 1)
                return;

            int swaps = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    swaps++;
                    if (input[j] > input[j + 1])
                    {
                        int t = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = t;
                    }
                }

                // if no swaps were made on the first pass the array is already
                // sorted and we can just return without doing anything
                if (swaps == 0)
                    return;
            }
        }
    }
}
