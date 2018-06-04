using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            var rollsPaper = int.Parse(Console.ReadLine());
            var rollsCloth = int.Parse(Console.ReadLine());
            var glue = double.Parse(Console.ReadLine());
            var discount = double.Parse(Console.ReadLine());
            var discountAfter = discount / 100;

            var priceRollsPaper = rollsPaper * 5.80;
            var priceRollsCloth = rollsCloth * 7.20;
            var priceGlue = glue * 1.20;
            var totalPrice = priceRollsCloth + priceRollsPaper + priceGlue;
            var priceDiscount = totalPrice - (totalPrice * discountAfter);

            Console.WriteLine(string.Format("{0:0.000}", priceDiscount));
        }
    }
}
