using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwarfPresents
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = int.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());

            var sandClock = 2.20;
            var magnet = 1.50;
            var cup = 5;
            var tshirt = 10;
            var totalPrice = 0.0;

            for (int i = 0; i < dwarfs; i++)
            {
                var presents = Console.ReadLine();
                switch (presents)
                {
                    case "sand clock":
                        totalPrice += sandClock;
                        break;
                    case "magnet":
                        totalPrice += magnet;
                            break;
                    case "cup":
                        totalPrice += cup;
                        break;
                    case "t-shirt":
                        totalPrice += tshirt;
                        break;
                    default:
                        break;
                }
            }
            if (totalPrice <= money)
            {
                var leftMoney = money - totalPrice;
                Console.WriteLine("Santa Claus has " + string.Format("{0:0.00}", leftMoney) + " more leva left!" );
            }
            else if (totalPrice > money)
            {
                var needMoney = totalPrice - money;
                Console.WriteLine("Santa Claus will need " + string.Format("{0:0.00}", needMoney) + " more leva.");
            }
        }
    }
}
