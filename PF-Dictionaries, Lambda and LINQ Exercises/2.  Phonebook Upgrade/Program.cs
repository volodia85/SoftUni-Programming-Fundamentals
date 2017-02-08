﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApplication235
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string commandLine = Console.ReadLine();
            while (!commandLine.Equals("END"))
            {
                string[] commandArgs = commandLine.Split(' ');
                string command = commandArgs[0];
                if (command.Equals("A"))
                {
                    AddNewEntry(phonebook, commandArgs);
                }
                else if (command.Equals("S"))
                {
                    PrintEntry(phonebook, commandArgs);
                }
                else if (command.Equals("ListAll"))
                {
                    PrintAllEntries(phonebook);
                }
                commandLine = Console.ReadLine();
            }
        }
        private static void PrintAllEntries(SortedDictionary<string, string> phonebook)
        {
            List<KeyValuePair<string, string>> orderedPhonebook = phonebook.OrderBy(x => x.Key).ToList();
            foreach (var entry in orderedPhonebook)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }
        }
        private static void PrintEntry(SortedDictionary<string, string> phonebook, string[] commandArgs)
        {
            string contact = commandArgs[1];
            if (phonebook.ContainsKey(contact))
            {
                Console.WriteLine("{0} -> {1}", contact, phonebook[contact]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", contact);
            }
        }
        private static void AddNewEntry(SortedDictionary<string, string> phonebook, string[] commandArgs)
        {
            string contact = commandArgs[1];
            string number = commandArgs[2];
            phonebook[contact] = number;
            
        }
    }
}