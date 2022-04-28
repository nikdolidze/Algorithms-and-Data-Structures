using System;

namespace Algorithms_and_Data_Structures.Basic
{
    // Write a C# Sharp program to swap two numbers
    public static class Swap
    {
        public static void SwapExample()
        {
            Console.WriteLine("Input the First Number ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            secondNumber = secondNumber + firstNumber;
            firstNumber = secondNumber - firstNumber;
            secondNumber = secondNumber - firstNumber;

            var memp = secondNumber;
            var second = firstNumber;
            var first = memp;

            Console.WriteLine("first number : " + firstNumber);
            Console.WriteLine("second number : " + secondNumber);
        }
    }
}
