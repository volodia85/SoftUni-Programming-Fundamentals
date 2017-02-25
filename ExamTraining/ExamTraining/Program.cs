using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ExamTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = double.Parse(Console.ReadLine());
            var numberOfGuests = double.Parse(Console.ReadLine());
            var priceOfBananas = double.Parse(Console.ReadLine());
            var priceOfEggs = double.Parse(Console.ReadLine());
            var priceOfBerries = double.Parse(Console.ReadLine());

            var portion = Math.Ceiling(numberOfGuests / 6);
            var onePortion = 2 * priceOfBananas + 4 * priceOfEggs + 0.2 * priceOfBerries;
            var neededProducts = onePortion * portion;

            if (neededProducts > cash)
            {
                var totalPrice = neededProducts - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {totalPrice:F2}lv more.");
            }
            else if (neededProducts <= cash)
            {
                var totalPrice = cash - neededProducts;
                Console.WriteLine($"Ivancho has enough money - it would cost {neededProducts:F2}lv.");
            }
            
        }
    }
}
