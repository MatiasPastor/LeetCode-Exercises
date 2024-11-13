using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEjercicios
{
    public class RemoveElement
    {
        /*
         Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.
        The order of the elements may be changed. Then return the number of elements in nums which are not
        equal to val.

        Consider the number of elements in nums which are not equal to val be k, to get accepted,
        you need to do the following things:

        Change the array nums such that the first k elements of nums contain the elements which are not equal to val.
        The remaining elements of nums are not important as well as the size of nums.
        Return k.
        */


        public int Solution(int?[] nums, int val)
        {
            int? aux = 0;
            int k = 0;
            int posmin = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = null;
                    
                }
                else
                {
                    k++;
                }
            }

            for (int i = 0; i < nums.Length - 1; i++) //ORDENAMIENTO POR SELECCION
            {
                posmin = i;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[posmin] > nums[j] || nums[posmin] == null && nums[j] != null)
                    {
                        posmin = j;
                    }
                }
                    aux = nums[i];
                    nums[i] = nums[posmin];
                    nums[posmin] = aux;        
            }

            foreach (int? num in nums)
            {
                Console.Write($"|{num.ToString()}|-" );
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Cantidad de numeros diferentes a val : {k}" );
            return k;
        }
    }
}
