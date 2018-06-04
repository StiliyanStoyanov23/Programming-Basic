using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());
            var totalTime = (time1 + time2 + time3);
            var min = totalTime / 60;
            var seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine(min + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(min + ":" + seconds);
            }

        }
    }
}
