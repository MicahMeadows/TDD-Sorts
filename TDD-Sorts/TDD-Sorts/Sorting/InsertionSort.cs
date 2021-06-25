// Insertion Sort is a very simple sorting algorithm
// that works similarly to sorting a deck of cards
// in your hands where you index through an array
// and put each element in its right spot before
// moving on to the next one

// Note:
// Insertion sort is not very efficient when working
// with large sets of data but is faster than more
// efficient algorithms such as merge sort or quick
// sort when working with small sets of dat 

// Time Complexity:
// Best Case: O(n)
// Worst Case: O(n^2)
// Average Case: O(n^2)

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
