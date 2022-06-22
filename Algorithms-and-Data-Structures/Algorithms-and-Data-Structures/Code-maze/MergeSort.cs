/*
Merge sort archives its purpose using a two-step process:
Devide: merge sorts starts by dividing the input array into two halves..The algorithms recursively calls itself for each of those halves until there are no half-arrays
to divide during the sorting procces.
Concur: the algorithm sorts and merges the sub-arrays in this step to return an array whose values are sorted
Generaly we use these hight-level steps when sorting an array or a list with a merge sort:
     check if the array has one element if it does it meand all the elemtn are sorted.
     use recursion to divide the array into two halbes until we cant divede it anymore.
     merge the array into  a new array whose values are sorted.
 
 */
namespace Algorithms_and_Data_Structures.Code_maze
{
    internal class MergeSort
	{
		public void MergeArray(int[] array, int left, int middle, int right)
		{
			var leftArrayLength = middle - left + 1;
			var rightArrayLength = right - middle;
			var leftTempArray = new int[leftArrayLength];
			var rightTempArray = new int[rightArrayLength];
			int i, j;

			for (i = 0; i < leftArrayLength; ++i)
				leftTempArray[i] = array[left + i];
			for (j = 0; j < rightArrayLength; ++j)
				rightTempArray[j] = array[middle + 1 + j];

			i = 0;
			j = 0;
			int k = left;

			while (i < leftArrayLength && j < rightArrayLength)
			{
				if (leftTempArray[i] <= rightTempArray[j])
				{
					array[k++] = leftTempArray[i++];
				}
				else
				{
					array[k++] = rightTempArray[j++];
				}
			}

			while (i < leftArrayLength)
			{
				array[k++] = leftTempArray[i++];
			}

			while (j < rightArrayLength)
			{
				array[k++] = rightTempArray[j++];
			}
		}

		public int[] SortArray(int[] array, int left, int right, string arrayName)
		{
			if (left < right)
			{
				int middle = left + (right - left) / 2;

				SortArray(array, left, middle, arrayName);
				SortArray(array, middle + 1, right, arrayName);

				MergeArray(array, left, middle, right);
			}

			return array;
		}

	}
}
