using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine()) + 15;
            string zero = "";

            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }

            if (minutes < 10)
            {
                zero = "0";
            }

            Console.WriteLine("{0}:{1}{2}", hours % 24, zero, minutes % 60);
        }
    }
}
