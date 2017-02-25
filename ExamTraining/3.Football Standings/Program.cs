using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.Football_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            List<string> teams = Console.ReadLine().ToLower().Split().ToList();

            List<string> league = new List<string>();
            while (!teams.Equals("final")) 
            {
                foreach (string item in teams)
                {
                    item.Replace(key, "");
                    league.Add(item);
                }
               

                teams = Console.ReadLine().ToLower().Split().ToList();
            }
            var players = RemoveSpecialCharacters(teams);
            Console.WriteLine(teams);
        }
        public static string[] RemoveSpecialCharacters(string[] str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
