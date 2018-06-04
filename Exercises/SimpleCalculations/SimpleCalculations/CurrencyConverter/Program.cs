using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var inputCurrency = Console.ReadLine();
            var outputCurrency = Console.ReadLine();

            if (inputCurrency == "BGN")
            {
                if (outputCurrency == "USD")
                {
                    var outputValue = Math.Round(value / 1.79549, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
                else if (outputCurrency == "EUR")
                {
                    var outputValue = Math.Round(value / 1.95583, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
                else if (outputCurrency == "GBP")
                {
                    var outputValue = Math.Round(value / 2.53405, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }

            }

            else if (inputCurrency == "USD")
            {
                if (outputCurrency == "BGN")
                {
                    var outputValue = Math.Round(value * 1.79549, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
                else if (outputCurrency == "EUR")
                {
                    var outputValue = Math.Round(value * 1.79549 / 1.95583, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
                else if (outputCurrency == "GBP")
                {
                    var outputValue = Math.Round(value * 1.79549 / 2.53405, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
            }

            else if (inputCurrency == "EUR")
            {
                if (outputCurrency == "BGN")
                {
                    var outputValue = Math.Round(value * 1.95583, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
                else if (outputCurrency == "USD")
                {
                    var outputValue = Math.Round(value * 1.95583 / 1.79549, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
                else if (outputCurrency == "GBP")
                {
                    var outputValue = Math.Round(value * 1.95583 / 2.53405, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
            }

            else if (inputCurrency == "GBP")
            {
                if (outputCurrency == "BGN")
                {
                    var outputValue = Math.Round(value * 2.53405, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
                else if (outputCurrency == "USD")
                {
                    var outputValue = Math.Round(value * 2.53405 / 1.79549, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
                else if (outputCurrency == "EUR")
                {
                    var outputValue = Math.Round(value * 2.53405 / 1.95583, 2);
                    Console.WriteLine(outputValue + " " + outputCurrency);
                }
            }
    }
}
