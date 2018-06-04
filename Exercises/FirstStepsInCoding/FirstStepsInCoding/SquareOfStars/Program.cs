using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var stars = int.Parse(Console.ReadLine());
            var starsTopAndBottom = new string('*', stars);

            Console.WriteLine(starsTopAndBottom);

            for (int i = 0; i < stars - 2 ; i++)
            {
                Console.WriteLine('*' + new string(' ', stars - 2) + '*');
            }

            Console.WriteLine(starsTopAndBottom);
        }
    }
}
