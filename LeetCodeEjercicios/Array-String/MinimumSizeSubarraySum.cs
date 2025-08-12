using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEjercicios
{
    public class MinimumSizeSubarraySum
    {

        /*Given an array of positive integers nums and a positive integer target,
          return the minimal length of a subarray
          whose sum is greater than or equal to target.
          If there is no such subarray, return 0 instead.*/
        
        public int Solution(int[] nums, int target)
        {
            int sol = 0, aux = 0;
            
            Array.Sort(nums);

            
                if(nums[nums.Length-1] >= target)
                {
                    Console.WriteLine(nums[nums.Length - 1]);
                    sol = 1;
                    return sol;
                } 
                for (int i = nums.Length-1; i > -1; i--, sol++)
                {
                    Console.WriteLine(nums[i]);
                     aux += nums[i];
                    if(aux >= target)
                    {
                        return sol += 1;
                    }
                }
                return 0;

        }
    }
}
