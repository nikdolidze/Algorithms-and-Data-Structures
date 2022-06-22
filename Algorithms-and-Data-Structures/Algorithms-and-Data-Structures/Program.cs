using Algorithms_and_Data_Structures.Basic;
using Algorithms_and_Data_Structures.Code_maze;
using Algorithms_and_Data_Structures.FromYoutube;
//https://www.w3resource.com/csharp-exercises/basic/index.php  exercises link
namespace Algorithms_and_Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 73, 57, 49, 99, 133, 20, 1, 34 };
            var mergeSort = new MergeSort();
            mergeSort.SortArray(array, 0, array.Length-1, "test");




            QuickSort();
            SwapM();
            SameSymbolCount();
            PrefixSum();
            FindNearest20();
        }

        public static void FindNearest20()
        {
            while (true)
            {
                NearestValue.NearestOf20();
            }
        }
        public static void PrefixSum()
        {
            var result = PrefixSums.PrefixSum(3, 7);

        }
        public static void SameSymbolCount()
        {
            var res = PrefixSums.SameSymbolCount("#..###");

        }
        static void QuickSort()
        {
            int[] array = { 52, 96, 67, 71, 42, 38, 39, 40, 14 };
            QuickSort quickSort = new();
            quickSort.SortArray(array, 0, array.Length - 1, "test");

        }
        public static void SwapM()
        {
            Swap.SwapExample();
        }
    }
}
