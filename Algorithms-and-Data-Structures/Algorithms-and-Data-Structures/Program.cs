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
            int[] array = { 52, 96, 67, 71, 42, 38, 39, 40, 14 };
            QuickSort quickSort = new();
            quickSort.SortArray(array, 0, array.Length - 1, "test");


            var res = PrefixSums.SameSymbolCount("#..###");

            var result =  PrefixSums.PrefixSum(3, 7);
            while (true)
            {
                NearestValue.NearestOf20();
            }
            Swap.SwapExample();
        }
    }
}
