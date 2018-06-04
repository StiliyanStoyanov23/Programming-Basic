using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewYearsEveParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = int.Parse(Console.ReadLine());
            var budgetFamily = double.Parse(Console.ReadLine());

            var neededMoney = guests * 20;

            if (neededMoney <= budgetFamily)
            {
                var leftMoney = budgetFamily - neededMoney;
                var fireworks = leftMoney * 0.40;
                var charity = leftMoney - fireworks;
                Console.WriteLine("Yes! {0} lv are for fireworks and {1} lv are for donation.", Math.Round(fireworks), Math.Round(charity) ) ;
            }
            else
            {
                var moreMoney = neededMoney - budgetFamily;
                Console.WriteLine("They won't have enough money to pay the covert. They will need {0} lv more.", Math.Round(moreMoney));
            }
        }
    }
}
