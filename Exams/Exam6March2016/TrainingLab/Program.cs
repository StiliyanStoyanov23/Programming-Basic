using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var wCm = w * 100;
            var hCm = h * 100;
            var hDesks = Math.Floor((hCm - 100) / 70);
            var wDesks = Math.Floor(wCm / 120);
            var totalDesks = hDesks * wDesks - 3;
            Console.WriteLine(totalDesks);
        }
    }
}
