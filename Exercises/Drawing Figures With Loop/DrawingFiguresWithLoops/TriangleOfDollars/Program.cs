﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var dollar = int.Parse(Console.ReadLine());

            for (int row = 1; row <= dollar; row++)
            {
                Console.Write('$');
                for (int col = 1; col < row; col++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
