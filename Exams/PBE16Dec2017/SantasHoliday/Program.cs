using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysToStay = int.Parse(Console.ReadLine());
            var typeRoom = Console.ReadLine();
            var typeRate = Console.ReadLine();

            var nightsToStay = daysToStay - 1;
            var price = 0.0;
            var discount = 0.0;
            var totalPrice = 0.0;
            var finalPrice = 0.0;

            if (typeRoom == "room for one person")
            {
                price = 18;
                totalPrice = price * nightsToStay;

                if (typeRate == "positive")
                {
                    finalPrice = (totalPrice * 0.25) + totalPrice;
                    Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                }
                else if (typeRate == "negative")
                {
                    finalPrice = totalPrice - (totalPrice * 0.10);
                    Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                }

            }
            else if (typeRoom == "apartment")
            {
                price = 25;
                totalPrice = price * nightsToStay;

                if (daysToStay < 10)
                {
                    discount = totalPrice * 0.30;
                    finalPrice = totalPrice - discount;
                    
                        if (typeRate == "positive")
                        {
                            finalPrice = (finalPrice * 0.25) + finalPrice;
                            Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                        }
                        else if (typeRate == "negative")
                        {
                            finalPrice = finalPrice - (finalPrice * 0.10);
                            Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                        }    
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    discount = totalPrice * 0.35;
                    finalPrice = totalPrice - discount;

                    if (typeRate == "positive")
                    {
                        finalPrice = (finalPrice * 0.25) + finalPrice;
                        Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                    }
                    else if (typeRate == "negative")
                    {
                        finalPrice = finalPrice - (finalPrice * 0.10);
                        Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                    }
                }
                else if (daysToStay > 15)
                {
                    discount = totalPrice * 0.50;
                    finalPrice = totalPrice - discount;

                    if (typeRate == "positive")
                    {
                        finalPrice = (finalPrice * 0.25) + finalPrice;
                        Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                    }
                    else if (typeRate == "negative")
                    {
                        finalPrice = finalPrice - (finalPrice * 0.10);
                        Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                    }
                }
            }
            else if (typeRoom == "president apartment")
            {
                price = 35;
                totalPrice = price * nightsToStay;

                if (daysToStay < 10)
                {
                    discount = totalPrice * 0.10;
                    finalPrice = totalPrice - discount;

                    if (typeRate == "positive")
                    {
                        finalPrice = (finalPrice * 0.25) + finalPrice;
                        Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                    }
                    else if (typeRate == "negative")
                    {
                        finalPrice = finalPrice - (finalPrice * 0.10);
                        Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                    }
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    discount = totalPrice * 0.15;
                    finalPrice = totalPrice - discount;

                    if (typeRate == "positive")
                    {
                        finalPrice = (finalPrice * 0.25) + finalPrice;
                        Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                    }
                    else if (typeRate == "negative")
                    {
                        finalPrice = finalPrice - (finalPrice * 0.10);
                        Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                    }
                }
                else if (daysToStay > 15)
                {
                    discount = totalPrice * 0.20;
                    finalPrice = totalPrice - discount;

                    if (typeRate == "positive")
                    {
                        finalPrice = (finalPrice * 0.25) + finalPrice;
                        Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                    }
                    else if (typeRate == "negative")
                    {
                        finalPrice = finalPrice - (finalPrice * 0.10);
                        Console.WriteLine(string.Format("{0:0.00}", finalPrice));
                    }
                }
            }
        }
    }
}
