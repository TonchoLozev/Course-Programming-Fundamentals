﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i-1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestStart = start;
                        bestLen = len;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }
               

            }
            for (int i = bestStart; i < bestLen+bestStart; i++)
            {
                Console.Write(string.Join(" ", array[i]) + " ");
            }
        }
    }
}
