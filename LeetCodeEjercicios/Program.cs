
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace LeetCodeEjercicios
{
    class Program
    {
        static int bucle = 0;

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
            //int[] array = new int[]{ 12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12 };
            //MinimumSizeSubarraySum sol = new MinimumSizeSubarraySum();
            //Console.WriteLine("Resultado: " + sol.Solution(array,213).ToString());
            //Console.ReadKey();

            //int num = 0;
            //int aux1 = 0;
            //int aux2 = 1;
            //for (int i = 0 ; i < 20 ; i++)
            //{
            //    num = aux1 + aux2;
            //    aux1 = aux2;
            //    aux2 = num;
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine("\n\n\n");
            //Console.WriteLine("Fibonacci con método");
            //Program obj = new Program();
            //obj.Fibonacci(0,1);
            //Console.ReadLine();

            Console.WriteLine("\n\n\n");
            int[] vector = { 1, 1, 5, 8 ,2 , 7 , 9};
            ContainerWater c = new ContainerWater();
            Console.WriteLine($"The maximum amount of water a container can store is {c.mostWater(vector)}");
            Console.WriteLine("\n\n\n");
            Console.ReadKey();

        }

        public void Fibonacci(int aux1, int aux2)
        {
            while (bucle < 20)
            {
                int num = aux1 + aux2;
                aux1 = aux2;
                aux2 = num;
                Console.WriteLine(num);
                bucle++;
                Fibonacci(aux1, aux2);
            }
            return;
        }
    }

}
