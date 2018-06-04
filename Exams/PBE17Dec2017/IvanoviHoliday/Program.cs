using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanoviHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            var nights = int.Parse(Console.ReadLine());
            var destination = Console.ReadLine();
            var transport = Console.ReadLine();

            var total = 0.0;
            var priceAdults = 0.0;
            var priceKids = 0.0;
            var priceAdultsTransport = 0.0;
            var priceKidsTransport = 0.0;

            if (destination == "Miami")
            {
                if (nights <= 10)
                {
                    if (transport == "train")
                    {
                        priceAdultsTransport = 22.30;
                        priceKidsTransport = 12.50;
                        priceAdults = 24.99;
                        priceKids = 14.99;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "bus")
                    {
                        priceAdultsTransport = 45;
                        priceKidsTransport = 37;
                        priceAdults = 24.99;
                        priceKids = 14.99;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "airplane")
                    {
                        priceAdultsTransport = 90;
                        priceKidsTransport = 68.50;
                        priceAdults = 24.99;
                        priceKids = 14.99;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    
                }
                else if (nights > 10 && nights <= 15)
                {
                    if (transport == "train")
                    {
                        priceAdultsTransport = 22.30;
                        priceKidsTransport = 12.50;
                        priceAdults = 22.99;
                        priceKids = 11.99;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "bus")
                    {
                        priceAdultsTransport = 45;
                        priceKidsTransport = 37;
                        priceAdults = 22.99;
                        priceKids = 11.99;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "airplane")
                    {
                        priceAdultsTransport = 90;
                        priceKidsTransport = 68.50;
                        priceAdults = 22.99;
                        priceKids = 11.99;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                }
                else if (nights > 15)
                {
                    if (transport == "train")
                    {
                        priceAdultsTransport = 22.30;
                        priceKidsTransport = 12.50;
                        priceAdults = 20;
                        priceKids = 10;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "bus")
                    {
                        priceAdultsTransport = 45;
                        priceKidsTransport = 37;
                        priceAdults = 20;
                        priceKids = 10;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "airplane")
                    {
                        priceAdultsTransport = 90;
                        priceKidsTransport = 68.50;
                        priceAdults = 20;
                        priceKids = 10;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                }
            }
            else if (destination == "Canary Islands")
            {
                if (nights <= 10)
                {
                    if (transport == "train")
                    {
                        priceAdultsTransport = 22.30;
                        priceKidsTransport = 12.50;
                        priceAdults = 32.50;
                        priceKids = 28.50;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "bus")
                    {
                        priceAdultsTransport = 45;
                        priceKidsTransport = 37;
                        priceAdults = 32.50;
                        priceKids = 28.50;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "airplane")
                    {
                        priceAdultsTransport = 90;
                        priceKidsTransport = 68.50;
                        priceAdults = 32.50;
                        priceKids = 28.50;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                }
                else if (nights > 10 && nights <= 15)
                {
                    if (transport == "train")
                    {
                        priceAdultsTransport = 22.30;
                        priceKidsTransport = 12.50;
                        priceAdults = 30.50;
                        priceKids = 25.60;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "bus")
                    {
                        priceAdultsTransport = 45;
                        priceKidsTransport = 37;
                        priceAdults = 30.50;
                        priceKids = 25.60;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "airplane")
                    {
                        priceAdultsTransport = 90;
                        priceKidsTransport = 68.50;
                        priceAdults = 30.50;
                        priceKids = 25.60;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                }
                else if (nights > 15)
                {
                    if (transport == "train")
                    {
                        priceAdultsTransport = 22.30;
                        priceKidsTransport = 12.50;
                        priceAdults = 28;
                        priceKids = 20;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "bus")
                    {
                        priceAdultsTransport = 45;
                        priceKidsTransport = 37;
                        priceAdults = 28;
                        priceKids = 20;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "airplane")
                    {
                        priceAdultsTransport = 90;
                        priceKidsTransport = 68.50;
                        priceAdults = 28;
                        priceKids = 20;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                }
            }
            else if (destination == "Philippines")
            {
                if (nights <= 10)
                {
                    if (transport == "train")
                    {
                        priceAdultsTransport = 22.30;
                        priceKidsTransport = 12.50;
                        priceAdults = 42.99;
                        priceKids = 39.99;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "bus")
                    {
                        priceAdultsTransport = 45;
                        priceKidsTransport = 37;
                        priceAdults = 42.99;
                        priceKids = 39.99;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "airplane")
                    {
                        priceAdultsTransport = 90;
                        priceKidsTransport = 68.50;
                        priceAdults = 42.99;
                        priceKids = 39.99;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                }
                else if (nights > 10 && nights <= 15)
                {
                    if (transport == "train")
                    {
                        priceAdultsTransport = 22.30;
                        priceKidsTransport = 12.50;
                        priceAdults = 41;
                        priceKids = 36;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "bus")
                    {
                        priceAdultsTransport = 45;
                        priceKidsTransport = 37;
                        priceAdults = 41;
                        priceKids = 36;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "airplane")
                    {
                        priceAdultsTransport = 90;
                        priceKidsTransport = 68.50;
                        priceAdults = 41;
                        priceKids = 36;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                }
                else if (nights > 15)
                {
                    if (transport == "train")
                    {
                        priceAdultsTransport = 22.30;
                        priceKidsTransport = 12.50;
                        priceAdults = 38.50;
                        priceKids = 32.40;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "bus")
                    {
                        priceAdultsTransport = 45;
                        priceKidsTransport = 37;
                        priceAdults = 38.50;
                        priceKids = 32.40;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                    else if (transport == "airplane")
                    {
                        priceAdultsTransport = 90;
                        priceKidsTransport = 68.50;
                        priceAdults = 38.50;
                        priceKids = 32.40;
                        total = ((2 * priceAdults) + (3 * priceKids)) * nights;
                        var totalPriceTransport = (2 * priceAdultsTransport) + (3 * priceKidsTransport);
                        var dogPrice = total * 0.25;
                        var totalPrice = total + dogPrice + totalPriceTransport;
                        Console.WriteLine(string.Format("{0:0.000}", totalPrice));
                    }
                }
            }
        }
    }
}
