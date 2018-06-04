using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var evenNum = 0;
            var oddNum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    evenNum = evenNum + int.Parse(Console.ReadLine());
                }
                else
                {
                    oddNum = oddNum + int.Parse(Console.ReadLine());
                }
            }
            if (evenNum == oddNum)
            {
                Console.WriteLine("Yes, sum = " + evenNum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(evenNum - oddNum));
            }
        }
    }
}
