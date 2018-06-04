using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());

            var weekendGames = (48 - h) * 3.0 / 4.0;
            var hGames = h;
            var pGames = p * 2.0 / 3.0;
            double totalGames = weekendGames + hGames + pGames;

            if (year == "leap")
            {
                var leapGames = totalGames * 0.15;
                Console.WriteLine(Math.Truncate(totalGames + leapGames));
            }
            else
            {
                Console.WriteLine(Math.Truncate(totalGames));
            }
        }
    }
}
