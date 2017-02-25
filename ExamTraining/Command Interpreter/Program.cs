using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class P01CommandInterpreter
{
    static void Main()
    {
        var numbers = Regex.Split(Console.ReadLine(), @"\s+").ToList();

        string command = Console.ReadLine();
        while (!command.ToLower().Equals("end"))
        {
            int startIndex = 0;
            int endIndex = 0;
            int count = 0;
            var commandSplit = Regex.Split(command, @"\s+");
            if (commandSplit.Length > 3)
            {
                startIndex = int.Parse(commandSplit[2]);
                endIndex = int.Parse(commandSplit[4]) + startIndex;
            }
            else
            {
                count = int.Parse(commandSplit[1]);
                if (count > int.MaxValue)
                {
                    count = int.MaxValue;
                }
            }

            if ((startIndex < 0 || startIndex > numbers.Count - 1) || (endIndex < 0 || endIndex > numbers.Count) || count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                switch (commandSplit[0])
                {
                    case "reverse":
                        Reverse(numbers, startIndex, endIndex);
                        break;
                    case "sort":
                        Sort(numbers, startIndex, endIndex);
                        break;
                    case "rollLeft":
                        if (count > numbers.Count)
                        {
                            count = count % numbers.Count;
                        }
                        RollLeft(numbers, count);
                        break;
                    case "rollRight":
                        if (count > numbers.Count)
                        {
                            count = count % numbers.Count;
                        }
                        RollRight(numbers, count);
                        break;
                }
            }
            command = Console.ReadLine();
        }

        Console.WriteLine(string.Format("[" + string.Join(", ", numbers) + "]"));
    }

    static List<string> Reverse(List<string> numbers, int startIndex, int endIndex)
    {
        List<string> sublist1 = new List<string>();
        List<string> sublist2 = new List<string>();
        List<string> sublist3 = new List<string>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (i < startIndex)
            {
                sublist1.Add(numbers[i]);
            }
            else if (i >= startIndex && i < endIndex)
            {
                sublist2.Add(numbers[i]);
            }
            else
            {
                sublist3.Add(numbers[i]);
            }
        }
        sublist2.Reverse();
        numbers.Clear();
        numbers.AddRange(sublist1);
        numbers.AddRange(sublist2);
        numbers.AddRange(sublist3);

        return numbers;
    }

    static List<string> Sort(List<string> numbers, int startIndex, int endIndex)
    {
        List<string> sublist1 = new List<string>();
        List<string> sublist2 = new List<string>();
        List<string> sublist3 = new List<string>();
        for (int i = 0; i < numbers.Count; i++)
        {
            if (i < startIndex)
            {
                sublist1.Add(numbers[i]);
            }
            else if (i >= startIndex && i < endIndex)
            {
                sublist2.Add(numbers[i]);
            }
            else
            {
                sublist3.Add(numbers[i]);
            }
        }
        sublist2.Sort();
        numbers.Clear();
        numbers.AddRange(sublist1);
        numbers.AddRange(sublist2);
        numbers.AddRange(sublist3);

        return numbers;
    }

    static List<string> RollLeft(List<string> numbers, int count)
    {
        while (count > 0)
        {
            string temp = numbers[0];
            numbers.RemoveAt(0);
            numbers.Add(temp);
            count--;
        }

        return numbers;
    }

    static List<string> RollRight(List<string> numbers, int count)
    {
        while (count > 0)
        {
            string temp = numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
            numbers.Insert(0, temp);
            count--;
        }

        return numbers;
    }
}