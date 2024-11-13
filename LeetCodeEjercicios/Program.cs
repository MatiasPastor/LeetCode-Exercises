using LeetCodeEjercicios.Array_String;
using System;
using System.Text.RegularExpressions;

namespace LeetCodeEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ar1 = new int[] {0};
            //int[] ar2 = new int[1];
            //int m = 0, n = 1;

            //MergeSortedArray sol = new MergeSortedArray();
            //sol.Solution(ar1, ar2, m, n);
            //Console.ReadKey();
            //int?[] array = { 4, 3, 3, 5, 2, 3 , 8 ,9 ,3 ,6 ,7};
            //int val = 3;
            //int final;

            //RemoveElement sol = new RemoveElement();
            //final = sol.Solution(array, val);

            //Palindrome sol = new Palindrome();
            //sol.Solution(" ");
            int[] array = new int[]{ 12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12 };
            MinimumSizeSubarraySum sol = new MinimumSizeSubarraySum();
            Console.WriteLine("Resultado: " + sol.Solution(array,213).ToString());
            Console.ReadKey();

        }
    }

}
