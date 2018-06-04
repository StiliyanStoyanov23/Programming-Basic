using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfTicket = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());

            var ticketPrice = 0.0;

            if (typeOfTicket == "Premiere")
            {
                ticketPrice = 12;
            }
            else if (typeOfTicket == "Normal")
            {
                ticketPrice = 7.50;
            }
            else if (typeOfTicket == "Discount")
            {
                ticketPrice = 5;
            }

            var totalIncome = rows * columns * ticketPrice;
            Console.WriteLine("{0:F2}", totalIncome);
        }
    }
}
