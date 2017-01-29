using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> badEmails = new Dictionary<string, List<string>>();
            
            string name = Console.ReadLine();
            while (name != "stop")
            {
                List<string> email = Console.ReadLine().Split('.').ToList();
                email.Reverse();
                if (email[0] == "us" || email[0] == "uk")
                {
                    
                }
                else
                {
                    email.Reverse();
                    emails.Add(name, email);
                }
                name = Console.ReadLine();
             }
            foreach (var item in emails)
            {
                Console.WriteLine("{0} -> {1}",item.Key, string.Join(".",item.Value) );
            }
           
        }
    }
}
