﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DrectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var x = Math.Abs(x1 - x2);
            var y = Math.Abs(y1 - y2);

            var area =x * y;
            var perimeter = 2 * (x + y);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
