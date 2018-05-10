﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 1; i <= n; i++)
            {
                var sumOfDigits = 0;
                int digits = i;
                while(digits>0)
                {
                    sumOfDigits += digits % 10;
                    digits /= 10;
                }
                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}",i,special);
            }

        }
    }
}
