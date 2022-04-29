using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Data_Structures.FromYoutube
{
    // იმპოვეთ მოცემულ ინდექსებს შორის მოთავსებული ელემენტების ჯამი, მოცემულ ინდექსზე არსებული ელემენტების ჩანთვლით
    internal static class PrefixSums
    {
        static int[] arr = new int[11] { 0, 9, 15, 2, 9, 20, 1, 11, 9, 10, 15 };

        public static int PrefixSum(int start, int end)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i];
            }

            var sum = arr[end] - arr[start - 1];
            return sum;
        }



        public static int SameSymbolCount(string str)
        {
            int result = 0;
            var arr = new int[10000];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                    arr[i] = arr[i - 1] + 1;
                else
                arr[i] = arr[i - 1];
            }
            Console.WriteLine("Amount");
            var m = Console.ReadLine();
            for (int i = 0; i <Convert.ToInt32( m); i++)
            {
                Console.WriteLine("X");
                var x =Convert.ToInt16( Console.ReadLine());
                var y =Convert.ToInt16( Console.ReadLine()); 
                 result = arr[y-1]-arr[x-1];

            }
            return result;

        }
    }
}
