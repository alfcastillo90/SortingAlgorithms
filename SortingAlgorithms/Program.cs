﻿using System;
namespace SortingAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 50, 10, 3, 2, 4 };

            Console.WriteLine("Before: 50, 10, 3, 2, 4");
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        Console.Write("{0}, ", nums[i]);
                        int temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                        Console.Write("{0}, ", nums[i]);
                        swapped = true;
                    }
                }
            } while (swapped == true);
            Console.Write("After: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }
            Console.ReadLine();
        }
    }
}
