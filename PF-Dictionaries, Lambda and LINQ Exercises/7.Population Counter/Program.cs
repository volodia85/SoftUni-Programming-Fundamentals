using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var countryPopulation = new Dictionary<string, Dictionary<string, int>>();

            while (!input.Contains("report"))
            {
                var line = input.Split('|');
                var city = line[0].ToString();
                var country = line[1].ToString();
                var population = int.Parse(line[2]);

                countryPopulation[country] = new Dictionary<string, int>();
                countryPopulation[country].Add(city, population);
                if (countryPopulation.ContainsKey(city))
                {
                    countryPopulation[country].Keys.Distinct();
                    countryPopulation[country].Values.Sum();
                }
                
            }
            foreach (var item in countryPopulation)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
