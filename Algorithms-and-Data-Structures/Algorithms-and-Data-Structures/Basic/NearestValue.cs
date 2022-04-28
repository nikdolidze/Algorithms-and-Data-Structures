using System;

namespace Algorithms_and_Data_Structures.Basic
{
    // Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same
    public static class NearestValue
    {
        public static void NearestOf20()
        {
            Console.WriteLine("Input the First Number ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());





            var firstDistance = firstNumber <0 ? Math.Abs(firstNumber) +20 :Math.Abs(20-firstNumber);
            var secondDistance = secondNumber <0 ? Math.Abs(secondNumber) +20 :Math.Abs(20-secondNumber);


            firstDistance = Math.Abs(firstNumber - 20);
            secondDistance = Math.Abs(secondNumber - 20);

            
            var rearest = firstDistance != secondDistance
                            ? firstDistance < secondDistance
                                    ? firstNumber
                                    : secondNumber
                                    : 0;

            Console.WriteLine(rearest);
            Console.WriteLine("-------");
        }
    }
}
