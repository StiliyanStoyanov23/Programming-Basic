using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanoviFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            var income = double.Parse(Console.ReadLine());
            var priceFirstGift = double.Parse(Console.ReadLine());
            var priceSecondGift = double.Parse(Console.ReadLine());
            var priceThirdGift = double.Parse(Console.ReadLine());

            var totalPrice = priceFirstGift + priceSecondGift + priceThirdGift;
            var leftMoney = income - totalPrice;
            var moneyCharity = leftMoney - (leftMoney * 0.10);
            Console.WriteLine(string.Format("{0:0.00}", moneyCharity));
        }
    }
}
