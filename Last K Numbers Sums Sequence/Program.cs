﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long [] array = new long[n];
            array[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i - k; j <= i - 1; j++)
                
                    if (j >= 0)
                        sum += array[j];
                   
                
                array[i] = sum;
            }
            for (int i = 0; i < n; i++)
            
                Console.Write(array[i] + " ");
                Console.WriteLine();
        }
    }
}
    
