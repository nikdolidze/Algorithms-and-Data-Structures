using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
quickSort algorithm uses the divide and conquer strategy to sort element in arrays or list. it implements this strategy by choosing an element as a pivot
and using it to partition the array.  The left subarray contains all elements that are less then pivot. the right subarray contains  all the elements that are
greater than the pivot.we recursively repeat this procces until we sort the array..We can select the pivot the algorithm uses during this element in different ways"
the fitst element of array
the last element of array
A random element of array
Median element of the araay
 */
namespace Algorithms_and_Data_Structures.Code_maze
{
    internal class QuickSort
    {
        public int[] SortArray(int[] array, int leftIndex, int rightIndex, string arrayName)
        {//            int[] array = { 52, 96, 67, 71, 42, 38, 39, 40, 14 };

            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                var v = array[i];
                while (array[i] < pivot)
                {
                    i++;
                }

                var t = array[j];
                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j, arrayName);

            if (i < rightIndex)
                SortArray(array, i, rightIndex, arrayName);

            return array;
            Console.WriteLine("======================");
        }

    }
}
