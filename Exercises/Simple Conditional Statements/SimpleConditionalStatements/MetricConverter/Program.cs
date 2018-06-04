using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var inputValue = Console.ReadLine();
            var outputValue = Console.ReadLine();
            var currencies = new Dictionary<string, double>()
            {
                {"mm", 1000 },
                {"cm", 100 },
                {"m", 1 },
                {"mi", 0.000621371192},
                {"in", 39.3700787},
                {"km", 0.001},
                {"ft", 3.2808399},
                {"yd", 1.0936133}
            };
            var result = value / currencies[inputValue] * currencies[outputValue];
            Console.WriteLine("{0} {1}", result, outputValue);
        }
    }
}
