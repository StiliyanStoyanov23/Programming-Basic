using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            bool isOnRight = (x == x1) && y >= y1 && y <= y2;
            bool isOnLeft = (x == x2) && y >= y1 && y <= y2;
            bool isOnTop = (y == y1) && x >= x1 && x <= x2;
            bool isOnBottom = (y == y2) && x >= x1 && x <= x2;

            if (isOnRight || isOnLeft || isOnTop || isOnBottom)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
