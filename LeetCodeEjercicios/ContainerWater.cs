using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//You are given an integer array height of length n. There are n vertical lines
//drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

//Find two lines that together with the x-axis form a container, such that the container contains the most water.

//Return the maximum amount of water a container can store.

//Notice that you may not slant the container.

namespace LeetCodeEjercicios
{
    public class ContainerWater
    {
        public long mostWater(int[] heightArray)
        {

            long volume = 0;
            int height = 0;

            for(int i = 0; i < heightArray.Length; i++)
            {
                for (int j = i + 1; j < heightArray.Length; j++)
                {
                    if (heightArray[i] == heightArray[j])
                    {
                        height = heightArray[j];
                        if (volume < (height * (j - i)))
                        {
                            volume = (height * (j - i));
                        }
                    }
                    else
                    {
                        height = (heightArray[i] > heightArray[j]) ? heightArray[j] : heightArray[i];
                        Console.WriteLine($"height = {height}");
                        if (volume < (height * (j - i)))
                        {
                            volume = (height * (j - i));
                        }
                    }
                    //Console.WriteLine($"volume = {volume}");
                }
                Console.WriteLine($"volume = {volume}");
                Console.WriteLine($"Fin vuelta {i}");
            }

            return volume;
            
        }


    }
}
