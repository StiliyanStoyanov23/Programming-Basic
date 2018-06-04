using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            var taxi = 0.0;
            var bus = 0.0;
            var train = 0.0;
            var totalPriceTaxi = 0.0;
            

            if (n < 20)
            {
                if (time == "day")
                {
                    taxi = 0.79;
                    totalPriceTaxi = 0.70 + taxi * n;
                }
                else if (time == "night")
                {
                    taxi = 0.90;
                    totalPriceTaxi = 0.70 + taxi * n;
                }
            }
            else if (n >= 20 && n <100)
            {
                if (time == "day")
                {
                    taxi = 0.79;
                    totalPriceTaxi = 0.70 + taxi * n;
                    bus = 0.09;
                    totalPric
                }
            }
        }
    }
}
