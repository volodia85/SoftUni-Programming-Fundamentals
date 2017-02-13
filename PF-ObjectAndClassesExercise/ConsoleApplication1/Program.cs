using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrase = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] city = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
            var phrase1 = 0;
            var events1 = 0;
            var author1 = 0;
            var city1 = 0;

            int numOfMessege = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfMessege; i++)
            {
                phrase1 = rnd.Next(0, phrase.Length);
                events1 = rnd.Next(0, events.Length);
                author1 = rnd.Next(0, author.Length);
                city1 = rnd.Next(0, city.Length);
                Console.WriteLine("{0} {1} {2} - {3}", string.Join(" ", phrase[phrase1]), string.Join(" ", events[events1]),
               string.Join(" ", author[author1]), string.Join(" ", city[city1]));
            }
        }
    }
}