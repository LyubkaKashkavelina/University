﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double megapixels = ((double)width * (double)height)/1000000;

            Console.WriteLine($"{width}x{height} => {Math.Round(megapixels,1)}MP");

        }
    }
}
