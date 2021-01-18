using System;

namespace DotNetMirror
{
    class ArrayReverseWithForLoop
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 }; //user input
            int arrLen = array.Length;
            int j = 0;
            int[] revArray = new int[arrLen]; //take same length of target array to reverse

            for (int i = arrLen - 1; i >= 0; i--)
            {
                revArray[j] = array[i];
                j++;
            }
            Console.WriteLine("Result: {0}", string.Join(",", revArray));
            Console.ReadKey();
        }
    }
}