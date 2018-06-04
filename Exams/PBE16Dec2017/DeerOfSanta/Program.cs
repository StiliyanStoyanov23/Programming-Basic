using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerOfSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysSantaMissing = int.Parse(Console.ReadLine());
            var leftFood = int.Parse(Console.ReadLine());
            var foodFirstDeer = double.Parse(Console.ReadLine());
            var foodSecondDeer = double.Parse(Console.ReadLine());
            var foodThirdDeer = double.Parse(Console.ReadLine());

            var neededFoodFirstDeer = daysSantaMissing * foodFirstDeer;
            var neededFoodSecondDeer = daysSantaMissing * foodSecondDeer;
            var neededFoodThirdDeer = daysSantaMissing * foodThirdDeer;
            var totalFoodNeeded = neededFoodFirstDeer + neededFoodSecondDeer + neededFoodThirdDeer;

            if (totalFoodNeeded <= leftFood)
            {
                var foodLeft = Math.Truncate(leftFood - totalFoodNeeded);
                Console.WriteLine(foodLeft + " kilos of food left.");
            }
            else if (totalFoodNeeded >= leftFood)
            {
                var foodNeed = Math.Round(totalFoodNeeded - leftFood);
                Console.WriteLine(foodNeed + " more kilos of food are needed.");
            }
        }
    }
}
